using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
/* =============== DATEBASE STRUCTURE ============== *
 * | DHT11_TEMP_WET_TBL    | RFID_TBL              | *
 * ------------------------------------------------- *
 * | id(N)(U)(PK)(AI)(INT) | id(N)(U)(PK)(AI)(INT) | *
 * | temp(INT)             | rfid(VARCHAR)         | *
 * | wet(INT)              | num(VARCHAR)          | *
 * | dht11_temp(INT)       | name(VARCHAR)         | *
 * | dht11_wet(INT)        | depart(VARCHAR)       | *
 * | date(DATETIME)        | pos(VARCHAR)          | *
 * |                       | phone(VARCHAR)        | *
 * |                       | enter_date(DATETIME)  | *
 * ================================================= */
/* ========================== RFID_TBL ========================= *
 * | 0                 | 1                 | 2                 | *
 * | 7C 78 4C 79       | 47 1D 95 5F       | 11 DE 66 A3       | *
 * | 7777777           | 88888888          | 890310            | *
 * | 칠칠이            | 팔팔이            | 김진혁            | *
 * | 칠성              | 팔도              | 서울기술교육센터  | *
 * | 계약직            | 정규직            | 교육생            | *
 * | 010-7777-7777     | 010-8888-8888     | 010-4940-9086     | *
 * | 2022-07-07        | 2022-08-08        | 2022-10-10        | *
 * ============================================================= */
namespace Smart_Factory
{
    public partial class Form1 : Form
    {
        static string connStr = "Server=127.0.0.1;Port=3306;Database=Smart_Factory_DB;Uid=root;Pwd=1234;";
        static string sql = "";
        static MySqlCommand cmd;
        static MySqlConnection conn;
        static MySqlDataReader reader;
        string inputData, temp, wet, dht11_temp, dht11_wet, rfid = "";
        string pretemp, prewet, predht11_temp, predht11_wet;
        string[] inputSensorData;
        int[] tempArray = new int[30];
        int[] wetArray = new int[30];
        int[] dht11_tempArray = new int[30];
        int[] dht11_wetArray = new int[30];
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
            timer1.Interval = 1000;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            button_RFID_Regist.Enabled = false;
            button_RFID_Modify.Enabled = false;
            button_RFID_Delete.Enabled = false;
            button_RFID_Each.Enabled = false;
            button_RFID_Whole.Enabled = true;
            button_RFID_Clear.Enabled = false;
        }
        // SETUP
        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_Port.Items.AddRange(ports);
        }
        private void button_OpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox_Port.Text == "") || (comboBox_BPS.Text == ""))
                    textBox_ReceiveData.Text = "No Selected UART Comport!";
                else
                {
                    serialPort1.PortName = comboBox_Port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_BPS.Text);
                    try
                    {
                        serialPort1.Open();
                        timer1.Start();
                        progressBar_PortStatus.Value = 100;
                        label_ComPort.Text = "O N";
                        label_ComPort.BackColor = Color.Green;
                        button_Send.Enabled = true;
                        button_Clear.Enabled = true;
                        textBox_SendData.Enabled = true;
                        button_OpenPort.Enabled = false;
                        button_ClosePort.Enabled = true;
                    }
                    catch (Exception err) { MessageBox.Show(err.Message); }
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox_ReceiveData.Text = "UART Open Exception Error!";
            }
        }
        private void button_ClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                timer1.Stop();
                progressBar_PortStatus.Value = 0;
                label_ComPort.Text = "OFF";
                label_ComPort.BackColor = Color.Red;
                button_Send.Enabled = false;
                button_Clear.Enabled = false;
                textBox_SendData.Enabled = false;
                button_OpenPort.Enabled = true;
                button_ClosePort.Enabled = false;
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((temp != null) && (wet != null) && (dht11_temp != null) && (dht11_wet != null))
            {
                displayRealTimeChart();
                displayRealTimeTable();
                // 추가 요구 사항 1. 온습도 변화되었을 때만 INSERT
                if ((pretemp != temp) || (prewet != wet)
                    || (predht11_temp != dht11_temp)
                    || (predht11_wet != dht11_wet))
                    insertDB();
                pretemp = temp;
                prewet = wet;
                predht11_temp = dht11_temp;
                predht11_wet = dht11_wet;
            }
        }
        void insertDB()
        {
            string nowDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // INSERT INTO DHT11_TEMP_WET_TBL (temp, wet, dht11_temp, dht11_wet, date)
            // VALUES (value_temp, value_wet, value_dht11_temp, value_dht11_wet, 'value_date');
            sql = "INSERT INTO DHT11_TEMP_WET_TBL (temp, wet, dht11_temp, dht11_wet, date) VALUES (";
            sql += temp + ", ";
            sql += wet + ", ";
            sql += dht11_temp + ", ";
            sql += dht11_wet + ", '";
            sql += nowDate + "');";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            LB_SensorDBStatus.Text = "OPEN";
            LB_SensorDBStatus.ForeColor = Color.Black;
            conn.Close();
        }
        void displayRealTimeTable()
        {
            if ((temp != null) && (wet != null) && (dht11_temp != null) && (dht11_wet != null))
            {
                string nowDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ListViewItem item = new ListViewItem(temp.ToString());
                item.SubItems.Add(wet);
                item.SubItems.Add(dht11_temp);
                item.SubItems.Add(dht11_wet);
                item.SubItems.Add(nowDate);
                listView1.Items.Add(item);
                listView1.EnsureVisible(listView1.Items.Count - 1);
            }
        }
        void displayRealTimeChart()
        {
            if ((temp != null) && (wet != null) && (dht11_temp != null) && (dht11_wet != null))
            {
                tempArray[tempArray.Length - 1] = int.Parse(temp);
                wetArray[wetArray.Length - 1] = int.Parse(wet);
                dht11_tempArray[dht11_tempArray.Length - 1] = int.Parse(dht11_temp);
                dht11_wetArray[dht11_wetArray.Length - 1] = int.Parse(dht11_wet);
                for (int i = 0; i < tempArray.Length - 1; i++)
                {
                    tempArray[i] = tempArray[i + 1];
                    wetArray[i] = wetArray[i + 1];
                    dht11_tempArray[i] = dht11_tempArray[i + 1];
                    dht11_wetArray[i] = dht11_wetArray[i + 1];
                }
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
                for (int i = 0; i < tempArray.Length; i++)
                {
                    chart1.Series[0].Points.AddXY(i, tempArray[i]);
                    chart1.Series[1].Points.AddXY(i, wetArray[i]);
                    chart1.Series[2].Points.AddXY(i, dht11_tempArray[i]);
                    chart1.Series[3].Points.AddXY(i, dht11_wetArray[i]);
                }
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // [TMP]:40\n[WET]:100\n[DHT11 TMP]:25\n[DHT11 WET]:50\n ... [RFID]: 11 AQ AS E1\n
            inputData = serialPort1.ReadLine(); // \n 만날 때까지 읽음
            this.Invoke(new EventHandler(showData));
        }
        private void showData(object sender, EventArgs e)
        {
            textBox_ReceiveData.Text += inputData;
            // POTENTIOMETER TEMP
            if (inputData.Contains("[TMP]:") == true)
            {
                inputSensorData = inputData.Split(':');
                int extemp;
                bool isNum = int.TryParse(inputSensorData[1], out extemp);
                if (isNum != true)
                    return;
                temp = inputSensorData[1].ToString();
            }
            // POTENTIOMETER WET
            if (inputData.Contains("[WET]:") == true)
            {
                inputSensorData = inputData.Split(':');
                int exwet;
                bool isNum = int.TryParse(inputSensorData[1], out exwet);
                if (isNum != true)
                    return;
                wet = inputSensorData[1].ToString();
            }
            // DHT11 TEMP
            if (inputData.Contains("[DHT11 TMP]:") == true)
            {
                inputSensorData = inputData.Split(':');
                int exdht11_temp;
                bool isNum = int.TryParse(inputSensorData[1], out exdht11_temp);
                if (isNum != true)
                    return;
                dht11_temp = inputSensorData[1].ToString();
            }
            // DHT11 WET
            if (inputData.Contains("[DHT11 WET]:") == true)
            {
                inputSensorData = inputData.Split(':');
                int exdht11_wet;
                bool isNum = int.TryParse(inputSensorData[1], out exdht11_wet);
                if (isNum != true)
                    return;
                dht11_wet = inputSensorData[1].ToString();
            }
            // RFID
            if (inputData.Contains("[RFID]:") == true)
            {
                // [RFID]: 11 AQ AS E1\n
                inputSensorData = inputData.Split(':');
                // \n REMOVE
                rfid = inputSensorData[1].Remove(inputSensorData[1].Length - 1);
                // " " REMOVE
                rfid = rfid.Remove(0, 1);
                // rfid = inputSensorData[1].SubString(0, 11);
                textBox_RFID_KEY1.Text = textBox_RFID_KEY2.Text = rfid;
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ReceiveData.Text = "";
        }
        private void button_Search_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker_FROMDATE.Value.Date + dateTimePicker_FROMTIME.Value.TimeOfDay;
            DateTime toDate = dateTimePicker_TODATE.Value.Date + dateTimePicker_TOTIME.Value.TimeOfDay;
            listView2.Items.Clear();
            searchHistory(fromDate, toDate);
        }
        private void textBox_RFID_KEY1_TextChanged(object sender, EventArgs e)
        {
            label_RFID_STATUS.Text = "RFID Card Registration Status";
            label_RFID_STATUS.ForeColor = Color.Gray;
            string num, name, depart, pos, phone, enter_date;
            if (textBox_RFID_KEY1.Text != "")
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                cmd = new MySqlCommand("", conn);
                // SELECT rfid FROM RFID_TBL WHERE rfid = '???';
                sql = "SELECT * FROM RFID_TBL WHERE rfid = '";
                sql += rfid + "';";
                cmd.CommandText = sql;
                reader = cmd.ExecuteReader();
                LB_RFIDDBStatus.Text = "OPEN";
                LB_RFIDDBStatus.ForeColor = Color.Black;
                if (reader.HasRows)
                {
                    label_RFID_STATUS.Text = "Already Registered RFID!";
                    label_RFID_STATUS.ForeColor = Color.Black;
                    button_RFID_Regist.Enabled = false;
                    button_RFID_Modify.Enabled = true;
                    button_RFID_Delete.Enabled = true;
                    button_RFID_Each.Enabled = true;
                    button_RFID_Whole.Enabled = true;
                    button_RFID_Clear.Enabled = true;
                    while (reader.Read())
                    {
                        num = reader["num"].ToString();
                        name = reader["name"].ToString();
                        depart = reader["depart"].ToString();
                        pos = reader["pos"].ToString();
                        phone = reader["phone"].ToString();
                        enter_date = reader["enter_date"].ToString();
                        textBox_RFID_num.Text = num;
                        textBox_RFID_name.Text = name;
                        textBox_RFID_depart.Text = depart;
                        textBox_RFID_pos.Text = pos;
                        textBox_RFID_phone.Text = phone;
                        textBox_RFID_enter_date.Text = enter_date;
                    }
                }
                else
                {
                    label_RFID_STATUS.Text = "Unregistered RFID!";
                    label_RFID_STATUS.ForeColor = Color.Black;
                    button_RFID_Regist.Enabled = true;
                    button_RFID_Modify.Enabled = false;
                    button_RFID_Delete.Enabled = false;
                    button_RFID_Each.Enabled = false;
                    button_RFID_Whole.Enabled = true;
                    button_RFID_Clear.Enabled = true;
                    textBox_RFID_num.Text
                    = textBox_RFID_name.Text
                    = textBox_RFID_depart.Text
                    = textBox_RFID_pos.Text
                    = textBox_RFID_phone.Text
                    = textBox_RFID_enter_date.Text
                    = "";
                }
                reader.Close();
                conn.Close();
            }
        }
        private void button_RFID_Regist_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // INSERT INTO RFID_TBL (rfid, num, name, depart, pos, phone, enter_date)
            // VALUES ('value_rfid', 'value_num', 'value_name', 'value_depart', 'value_pos', 'value_phone', 'value_enter_date');
            sql = "INSERT INTO RFID_TBL (rfid, num, name, depart, pos, phone, enter_date) VALUES ('";
            sql += rfid + "', ";
            if (textBox_RFID_num.Text != "")
                sql += "'" + textBox_RFID_num.Text + "', ";
            else sql += "null, ";
            if (textBox_RFID_name.Text != "")
                sql += "'" + textBox_RFID_name.Text + "', ";
            else sql += "null, ";
            if (textBox_RFID_depart.Text != "")
                sql += "'" + textBox_RFID_depart.Text + "', ";
            else sql += "null, ";
            if (textBox_RFID_pos.Text != "")
                sql += "'" + textBox_RFID_pos.Text + "', ";
            else sql += "null, ";
            if (textBox_RFID_phone.Text != "")
                sql += "'" + textBox_RFID_phone.Text + "', ";
            else sql += "null, ";
            if (textBox_RFID_enter_date.Text != "")
                sql += "'" + textBox_RFID_enter_date.Text + "');";
            else sql += "null);";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
            rfid
                = textBox_RFID_KEY1.Text
                = textBox_RFID_KEY2.Text
                = textBox_RFID_num.Text
                = textBox_RFID_name.Text
                = textBox_RFID_depart.Text
                = textBox_RFID_pos.Text
                = textBox_RFID_phone.Text
                = textBox_RFID_enter_date.Text
                = "";
        }
        private void button_RFID_Modify_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // UPDATE RFID_TBL SET num = 'num_value', name = 'name_value',
            // depart = 'depart_value', pos = 'pos_value',
            // phone = 'phone_value', enter_date = 'enter_date_value'
            // WHERE rfid = '????';
            sql = "UPDATE RFID_TBL SET num = ";
            if (textBox_RFID_num.Text != "")
                sql += "'" + textBox_RFID_num.Text + "', ";
            else sql += "null, ";
            sql += "name = ";
            if (textBox_RFID_name.Text != "")
                sql += "'" + textBox_RFID_name.Text + "', ";
            else sql += "null, ";
            sql += "depart = ";
            if (textBox_RFID_depart.Text != "")
                sql += "'" + textBox_RFID_depart.Text + "', ";
            else sql += "null, ";
            sql += "pos = ";
            if (textBox_RFID_pos.Text != "")
                sql += "'" + textBox_RFID_pos.Text + "', ";
            else sql += "null, ";
            sql += "phone = ";
            if (textBox_RFID_phone.Text != "")
                sql += "'" + textBox_RFID_phone.Text + "', ";
            else sql += "null, ";
            sql += "enter_date = ";
            if (textBox_RFID_enter_date.Text != "")
                sql += "'" + textBox_RFID_enter_date.Text + "' ";
            else sql += "null ";
            sql += "WHERE rfid = '" + rfid + "';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
            rfid
                = textBox_RFID_KEY1.Text
                = textBox_RFID_KEY2.Text
                = textBox_RFID_num.Text
                = textBox_RFID_name.Text
                = textBox_RFID_depart.Text
                = textBox_RFID_pos.Text
                = textBox_RFID_phone.Text
                = textBox_RFID_enter_date.Text
                = "";
        }
        private void button_RFID_Delete_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // DELETE FROM RFID_TBL WHERE rfid = '????';
            sql = "DELETE FROM RFID_TBL WHERE rfid = '";
            sql += rfid + "';";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            conn.Close();
            rfid
                = textBox_RFID_KEY1.Text
                = textBox_RFID_KEY2.Text
                = textBox_RFID_num.Text
                = textBox_RFID_name.Text
                = textBox_RFID_depart.Text
                = textBox_RFID_pos.Text
                = textBox_RFID_phone.Text
                = textBox_RFID_enter_date.Text
                = "";
        }
        private void button_RFID_Each_Click(object sender, EventArgs e)
        {
            string num, name, depart, pos, phone, enter_date;
            listView3.Items.Clear();
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // SELECT * FROM RFID_TBL WHERE rfid = '???';
            sql = "SELECT * FROM RFID_TBL WHERE rfid = '";
            sql += rfid + "';";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                num = reader["num"].ToString();
                name = reader["name"].ToString();
                depart = reader["depart"].ToString();
                pos = reader["pos"].ToString();
                phone = reader["phone"].ToString();
                enter_date = reader["enter_date"].ToString();
                ListViewItem item = new ListViewItem(rfid.ToString());
                item.SubItems.Add(num);
                item.SubItems.Add(depart);
                item.SubItems.Add(pos);
                item.SubItems.Add(name);
                item.SubItems.Add(phone);
                item.SubItems.Add(enter_date);
                listView3.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }
        private void button_RFID_Whole_Click(object sender, EventArgs e)
        {
            int count = 0;
            string exrfid, num, name, depart, pos, phone, enter_date;
            listView3.Items.Clear();
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // SELECT * FROM RFID_TBL;
            sql = "SELECT * FROM RFID_TBL;";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                exrfid = reader["rfid"].ToString();
                num = reader["num"].ToString();
                name = reader["name"].ToString();
                depart = reader["depart"].ToString();
                pos = reader["pos"].ToString();
                phone = reader["phone"].ToString();
                enter_date = reader["enter_date"].ToString();
                count++;
                ListViewItem item = new ListViewItem(exrfid.ToString());
                item.SubItems.Add(num);
                item.SubItems.Add(depart);
                item.SubItems.Add(pos);
                item.SubItems.Add(name);
                item.SubItems.Add(phone);
                item.SubItems.Add(enter_date);
                listView3.Items.Add(item);
            }
            reader.Close();
            conn.Close();
        }
        private void button_RFID_Clear_Click(object sender, EventArgs e)
        {
            rfid
                = textBox_RFID_KEY1.Text
                = textBox_RFID_KEY2.Text
                = textBox_RFID_num.Text
                = textBox_RFID_name.Text
                = textBox_RFID_depart.Text
                = textBox_RFID_pos.Text
                = textBox_RFID_phone.Text
                = textBox_RFID_enter_date.Text
                = "";
            listView3.Items.Clear();
        }
        private void tabControl1_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabControl1.SelectedIndex == 7) // tabPage_Exit
            {
                DialogResult dr1 = MessageBox.Show("Are you sure you want to exit the program?",
                    "Quit!", MessageBoxButtons.YesNo);
                if (dr1 == DialogResult.Yes)
                {
                    timer1.Stop();
                    serialPort1.Close();
                    Application.Exit();
                }
                else return;
            }
        }
        void searchHistory(DateTime fromDate, DateTime toDate)
        {
            // ex) DateTime: 2022-10-05 오후 01:32:00 -> MySQL: 2022-10-05 13:32:00
            string exfrom = fromDate.ToString("yyyy-MM-dd HH:mm:ss");
            string exto = toDate.ToString("yyyy-MM-dd HH:mm:ss");
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            // SELECT * FROM DHT11_TEMP_WET_TBL WHERE date >= '2022-10-05 12:32:00' AND date <= '2022-10-05 13:32:00' ORDER BY date;
            sql = "SELECT * FROM DHT11_TEMP_WET_TBL WHERE date >= '";
            sql += exfrom + "' AND date <= '";
            sql += exto + "' ORDER BY date;";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            // TEMP-WET CHART
            DateTime infoTime;
            int temp, wet, dht11_temp, dht11_wet, count = 0;
            List<int> tempList = new List<int>();
            List<int> wetList = new List<int>();
            List<int> dht11_tempList = new List<int>();
            List<int> dht11_wetList = new List<int>();
            while (reader.Read())
            {
                temp = (int)reader["temp"];
                wet = (int)reader["wet"];
                dht11_temp = (int)reader["dht11_temp"];
                dht11_wet = (int)reader["dht11_wet"];
                infoTime = (DateTime)reader["date"];
                tempList.Add(temp);
                wetList.Add(wet);
                dht11_tempList.Add(dht11_temp);
                dht11_wetList.Add(dht11_wet);
                count++;
                ListViewItem item = new ListViewItem(count.ToString());
                item.SubItems.Add(temp.ToString());
                item.SubItems.Add(wet.ToString());
                item.SubItems.Add(dht11_temp.ToString());
                item.SubItems.Add(dht11_wet.ToString());
                item.SubItems.Add(infoTime.ToString());
                listView2.Items.Add(item);
            }
            // DISPLAY
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();
            chart2.Series[3].Points.Clear();
            for (int i = 0; i < count; i++)
            {
                chart2.Series[0].Points.AddXY(i, tempList[i]);
                chart2.Series[1].Points.AddXY(i, wetList[i]);
                chart2.Series[2].Points.AddXY(i, dht11_tempList[i]);
                chart2.Series[3].Points.AddXY(i, dht11_wetList[i]);
            }
            reader.Close();
            conn.Close();
        }
    }
}