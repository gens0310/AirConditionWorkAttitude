namespace Smart_Factory
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Setup = new System.Windows.Forms.TabPage();
            this.LB_RFIDDBStatus = new System.Windows.Forms.Label();
            this.LB_SensorDBStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_SendData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_ReceiveData = new System.Windows.Forms.TextBox();
            this.button_ClosePort = new System.Windows.Forms.Button();
            this.button_OpenPort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ComPort = new System.Windows.Forms.Label();
            this.progressBar_PortStatus = new System.Windows.Forms.ProgressBar();
            this.comboBox_BPS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.tabPage_Monitoring = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_TEMP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_WET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DHT11_TEMP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DHT11_WET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_TIME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_History = new System.Windows.Forms.TabPage();
            this.button_Search = new System.Windows.Forms.Button();
            this.dateTimePicker_TOTIME = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_TODATE = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker_FROMTIME = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_FROMDATE = new System.Windows.Forms.DateTimePicker();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader_HISTORY_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HISTORY_TEMP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HISTORY_WET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HISTORY_DHT11_TEMP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HISTORY_DHT11_WET = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_HISTORY_TIME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage_Control = new System.Windows.Forms.TabPage();
            this.tabPage_Warehouse = new System.Windows.Forms.TabPage();
            this.tabPage_RFID = new System.Windows.Forms.TabPage();
            this.label_RFID_STATUS = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_RFID_KEY1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage_ABS = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader_RFID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_DEPART = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_POS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_PHONE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ENTER_DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_RFID_enter_date = new System.Windows.Forms.TextBox();
            this.textBox_RFID_phone = new System.Windows.Forms.TextBox();
            this.textBox_RFID_name = new System.Windows.Forms.TextBox();
            this.textBox_RFID_pos = new System.Windows.Forms.TextBox();
            this.textBox_RFID_depart = new System.Windows.Forms.TextBox();
            this.textBox_RFID_num = new System.Windows.Forms.TextBox();
            this.textBox_RFID_KEY2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_RFID_Clear = new System.Windows.Forms.Button();
            this.button_RFID_Whole = new System.Windows.Forms.Button();
            this.button_RFID_Each = new System.Windows.Forms.Button();
            this.button_RFID_Delete = new System.Windows.Forms.Button();
            this.button_RFID_Modify = new System.Windows.Forms.Button();
            this.button_RFID_Regist = new System.Windows.Forms.Button();
            this.tabPage_Exit = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_Setup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Monitoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage_History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage_RFID.SuspendLayout();
            this.tabPage_ABS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Setup);
            this.tabControl1.Controls.Add(this.tabPage_Monitoring);
            this.tabControl1.Controls.Add(this.tabPage_History);
            this.tabControl1.Controls.Add(this.tabPage_Control);
            this.tabControl1.Controls.Add(this.tabPage_Warehouse);
            this.tabControl1.Controls.Add(this.tabPage_RFID);
            this.tabControl1.Controls.Add(this.tabPage_ABS);
            this.tabControl1.Controls.Add(this.tabPage_Exit);
            this.tabControl1.Location = new System.Drawing.Point(30, 68);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 304);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_Menu_SelectedIndexChanged);
            // 
            // tabPage_Setup
            // 
            this.tabPage_Setup.Controls.Add(this.LB_RFIDDBStatus);
            this.tabPage_Setup.Controls.Add(this.LB_SensorDBStatus);
            this.tabPage_Setup.Controls.Add(this.label7);
            this.tabPage_Setup.Controls.Add(this.label6);
            this.tabPage_Setup.Controls.Add(this.button_Send);
            this.tabPage_Setup.Controls.Add(this.button_Clear);
            this.tabPage_Setup.Controls.Add(this.groupBox3);
            this.tabPage_Setup.Controls.Add(this.groupBox2);
            this.tabPage_Setup.Controls.Add(this.button_ClosePort);
            this.tabPage_Setup.Controls.Add(this.button_OpenPort);
            this.tabPage_Setup.Controls.Add(this.groupBox1);
            this.tabPage_Setup.Controls.Add(this.progressBar_PortStatus);
            this.tabPage_Setup.Controls.Add(this.comboBox_BPS);
            this.tabPage_Setup.Controls.Add(this.label4);
            this.tabPage_Setup.Controls.Add(this.label3);
            this.tabPage_Setup.Controls.Add(this.label2);
            this.tabPage_Setup.Controls.Add(this.comboBox_Port);
            this.tabPage_Setup.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Setup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Setup.Name = "tabPage_Setup";
            this.tabPage_Setup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Setup.Size = new System.Drawing.Size(872, 278);
            this.tabPage_Setup.TabIndex = 0;
            this.tabPage_Setup.Text = "Setup";
            this.tabPage_Setup.UseVisualStyleBackColor = true;
            // 
            // LB_RFIDDBStatus
            // 
            this.LB_RFIDDBStatus.AutoSize = true;
            this.LB_RFIDDBStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_RFIDDBStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LB_RFIDDBStatus.Location = new System.Drawing.Point(160, 237);
            this.LB_RFIDDBStatus.Name = "LB_RFIDDBStatus";
            this.LB_RFIDDBStatus.Size = new System.Drawing.Size(51, 12);
            this.LB_RFIDDBStatus.TabIndex = 12;
            this.LB_RFIDDBStatus.Text = "CLOSE";
            // 
            // LB_SensorDBStatus
            // 
            this.LB_SensorDBStatus.AutoSize = true;
            this.LB_SensorDBStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LB_SensorDBStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LB_SensorDBStatus.Location = new System.Drawing.Point(160, 205);
            this.LB_SensorDBStatus.Name = "LB_SensorDBStatus";
            this.LB_SensorDBStatus.Size = new System.Drawing.Size(51, 12);
            this.LB_SensorDBStatus.TabIndex = 11;
            this.LB_SensorDBStatus.Text = "CLOSE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "RFID DB Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sensor DB Status";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(791, 228);
            this.button_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(66, 28);
            this.button_Send.TabIndex = 9;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(791, 33);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(66, 28);
            this.button_Clear.TabIndex = 9;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_SendData);
            this.groupBox3.Location = new System.Drawing.Point(242, 212);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(532, 55);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Data";
            // 
            // textBox_SendData
            // 
            this.textBox_SendData.Location = new System.Drawing.Point(24, 20);
            this.textBox_SendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SendData.Name = "textBox_SendData";
            this.textBox_SendData.Size = new System.Drawing.Size(488, 21);
            this.textBox_SendData.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_ReceiveData);
            this.groupBox2.Location = new System.Drawing.Point(242, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(532, 185);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Data";
            // 
            // textBox_ReceiveData
            // 
            this.textBox_ReceiveData.Location = new System.Drawing.Point(24, 20);
            this.textBox_ReceiveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ReceiveData.Multiline = true;
            this.textBox_ReceiveData.Name = "textBox_ReceiveData";
            this.textBox_ReceiveData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ReceiveData.Size = new System.Drawing.Size(488, 156);
            this.textBox_ReceiveData.TabIndex = 0;
            // 
            // button_ClosePort
            // 
            this.button_ClosePort.Location = new System.Drawing.Point(21, 154);
            this.button_ClosePort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ClosePort.Name = "button_ClosePort";
            this.button_ClosePort.Size = new System.Drawing.Size(73, 28);
            this.button_ClosePort.TabIndex = 6;
            this.button_ClosePort.Text = "Close Port";
            this.button_ClosePort.UseVisualStyleBackColor = true;
            this.button_ClosePort.Click += new System.EventHandler(this.button_ClosePort_Click);
            // 
            // button_OpenPort
            // 
            this.button_OpenPort.Location = new System.Drawing.Point(21, 116);
            this.button_OpenPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OpenPort.Name = "button_OpenPort";
            this.button_OpenPort.Size = new System.Drawing.Size(73, 28);
            this.button_OpenPort.TabIndex = 6;
            this.button_OpenPort.Text = "Open Port";
            this.button_OpenPort.UseVisualStyleBackColor = true;
            this.button_OpenPort.Click += new System.EventHandler(this.button_OpenPort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_ComPort);
            this.groupBox1.Location = new System.Drawing.Point(109, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(102, 66);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComPort";
            // 
            // label_ComPort
            // 
            this.label_ComPort.AutoSize = true;
            this.label_ComPort.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ComPort.Location = new System.Drawing.Point(16, 24);
            this.label_ComPort.Name = "label_ComPort";
            this.label_ComPort.Size = new System.Drawing.Size(68, 27);
            this.label_ComPort.TabIndex = 0;
            this.label_ComPort.Text = "OFF";
            // 
            // progressBar_PortStatus
            // 
            this.progressBar_PortStatus.Location = new System.Drawing.Point(106, 81);
            this.progressBar_PortStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar_PortStatus.Name = "progressBar_PortStatus";
            this.progressBar_PortStatus.Size = new System.Drawing.Size(106, 18);
            this.progressBar_PortStatus.TabIndex = 4;
            // 
            // comboBox_BPS
            // 
            this.comboBox_BPS.FormattingEnabled = true;
            this.comboBox_BPS.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_BPS.Location = new System.Drawing.Point(106, 51);
            this.comboBox_BPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BPS.Name = "comboBox_BPS";
            this.comboBox_BPS.Size = new System.Drawing.Size(106, 20);
            this.comboBox_BPS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F);
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Port Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.Location = new System.Drawing.Point(19, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "BPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(106, 21);
            this.comboBox_Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(106, 20);
            this.comboBox_Port.TabIndex = 0;
            // 
            // tabPage_Monitoring
            // 
            this.tabPage_Monitoring.Controls.Add(this.chart1);
            this.tabPage_Monitoring.Controls.Add(this.listView1);
            this.tabPage_Monitoring.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Monitoring.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Monitoring.Name = "tabPage_Monitoring";
            this.tabPage_Monitoring.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Monitoring.Size = new System.Drawing.Size(872, 278);
            this.tabPage_Monitoring.TabIndex = 1;
            this.tabPage_Monitoring.Text = "Monitoring";
            this.tabPage_Monitoring.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(417, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "TEMP";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "WET";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "DHT11_TEMP";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "DHT11_WET";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(449, 267);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_TEMP,
            this.columnHeader_WET,
            this.columnHeader_DHT11_TEMP,
            this.columnHeader_DHT11_WET,
            this.columnHeader_TIME});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 267);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_TEMP
            // 
            this.columnHeader_TEMP.Text = "TEMP";
            this.columnHeader_TEMP.Width = 50;
            // 
            // columnHeader_WET
            // 
            this.columnHeader_WET.Text = "WET";
            this.columnHeader_WET.Width = 50;
            // 
            // columnHeader_DHT11_TEMP
            // 
            this.columnHeader_DHT11_TEMP.Text = "DHT11_TEMP";
            this.columnHeader_DHT11_TEMP.Width = 75;
            // 
            // columnHeader_DHT11_WET
            // 
            this.columnHeader_DHT11_WET.Text = "DHT11_WET";
            this.columnHeader_DHT11_WET.Width = 75;
            // 
            // columnHeader_TIME
            // 
            this.columnHeader_TIME.Text = "TIME";
            this.columnHeader_TIME.Width = 150;
            // 
            // tabPage_History
            // 
            this.tabPage_History.Controls.Add(this.button_Search);
            this.tabPage_History.Controls.Add(this.dateTimePicker_TOTIME);
            this.tabPage_History.Controls.Add(this.dateTimePicker_TODATE);
            this.tabPage_History.Controls.Add(this.label8);
            this.tabPage_History.Controls.Add(this.dateTimePicker_FROMTIME);
            this.tabPage_History.Controls.Add(this.dateTimePicker_FROMDATE);
            this.tabPage_History.Controls.Add(this.chart2);
            this.tabPage_History.Controls.Add(this.listView2);
            this.tabPage_History.Location = new System.Drawing.Point(4, 22);
            this.tabPage_History.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_History.Name = "tabPage_History";
            this.tabPage_History.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_History.Size = new System.Drawing.Size(872, 278);
            this.tabPage_History.TabIndex = 2;
            this.tabPage_History.Text = "History";
            this.tabPage_History.UseVisualStyleBackColor = true;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(676, 6);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 8;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dateTimePicker_TOTIME
            // 
            this.dateTimePicker_TOTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_TOTIME.Location = new System.Drawing.Point(505, 7);
            this.dateTimePicker_TOTIME.Name = "dateTimePicker_TOTIME";
            this.dateTimePicker_TOTIME.ShowUpDown = true;
            this.dateTimePicker_TOTIME.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_TOTIME.TabIndex = 7;
            // 
            // dateTimePicker_TODATE
            // 
            this.dateTimePicker_TODATE.Location = new System.Drawing.Point(319, 7);
            this.dateTimePicker_TODATE.Name = "dateTimePicker_TODATE";
            this.dateTimePicker_TODATE.Size = new System.Drawing.Size(180, 21);
            this.dateTimePicker_TODATE.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "~";
            // 
            // dateTimePicker_FROMTIME
            // 
            this.dateTimePicker_FROMTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_FROMTIME.Location = new System.Drawing.Point(193, 7);
            this.dateTimePicker_FROMTIME.Name = "dateTimePicker_FROMTIME";
            this.dateTimePicker_FROMTIME.ShowUpDown = true;
            this.dateTimePicker_FROMTIME.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker_FROMTIME.TabIndex = 4;
            // 
            // dateTimePicker_FROMDATE
            // 
            this.dateTimePicker_FROMDATE.Location = new System.Drawing.Point(7, 7);
            this.dateTimePicker_FROMDATE.Name = "dateTimePicker_FROMDATE";
            this.dateTimePicker_FROMDATE.Size = new System.Drawing.Size(180, 21);
            this.dateTimePicker_FROMDATE.TabIndex = 3;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(417, 33);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "TEMP";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "WET";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "DHT11_TEMP";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "DHT11_WET";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(449, 240);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_HISTORY_ID,
            this.columnHeader_HISTORY_TEMP,
            this.columnHeader_HISTORY_WET,
            this.columnHeader_HISTORY_DHT11_TEMP,
            this.columnHeader_HISTORY_DHT11_WET,
            this.columnHeader_HISTORY_TIME});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(7, 33);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(404, 240);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_HISTORY_ID
            // 
            this.columnHeader_HISTORY_ID.Text = "ID";
            this.columnHeader_HISTORY_ID.Width = 50;
            // 
            // columnHeader_HISTORY_TEMP
            // 
            this.columnHeader_HISTORY_TEMP.Text = "TEMP";
            this.columnHeader_HISTORY_TEMP.Width = 50;
            // 
            // columnHeader_HISTORY_WET
            // 
            this.columnHeader_HISTORY_WET.Text = "WET";
            this.columnHeader_HISTORY_WET.Width = 50;
            // 
            // columnHeader_HISTORY_DHT11_TEMP
            // 
            this.columnHeader_HISTORY_DHT11_TEMP.Text = "DHT11_TEMP";
            this.columnHeader_HISTORY_DHT11_TEMP.Width = 50;
            // 
            // columnHeader_HISTORY_DHT11_WET
            // 
            this.columnHeader_HISTORY_DHT11_WET.Text = "DHT11_WET";
            this.columnHeader_HISTORY_DHT11_WET.Width = 50;
            // 
            // columnHeader_HISTORY_TIME
            // 
            this.columnHeader_HISTORY_TIME.Text = "TIME";
            this.columnHeader_HISTORY_TIME.Width = 150;
            // 
            // tabPage_Control
            // 
            this.tabPage_Control.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Control.Name = "tabPage_Control";
            this.tabPage_Control.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Control.Size = new System.Drawing.Size(872, 278);
            this.tabPage_Control.TabIndex = 3;
            this.tabPage_Control.Text = "Control";
            this.tabPage_Control.UseVisualStyleBackColor = true;
            // 
            // tabPage_Warehouse
            // 
            this.tabPage_Warehouse.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Warehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Warehouse.Name = "tabPage_Warehouse";
            this.tabPage_Warehouse.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Warehouse.Size = new System.Drawing.Size(872, 278);
            this.tabPage_Warehouse.TabIndex = 4;
            this.tabPage_Warehouse.Text = "Warehouse";
            this.tabPage_Warehouse.UseVisualStyleBackColor = true;
            // 
            // tabPage_RFID
            // 
            this.tabPage_RFID.Controls.Add(this.label_RFID_STATUS);
            this.tabPage_RFID.Controls.Add(this.label10);
            this.tabPage_RFID.Controls.Add(this.textBox_RFID_KEY1);
            this.tabPage_RFID.Controls.Add(this.label9);
            this.tabPage_RFID.Location = new System.Drawing.Point(4, 22);
            this.tabPage_RFID.Name = "tabPage_RFID";
            this.tabPage_RFID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_RFID.Size = new System.Drawing.Size(872, 278);
            this.tabPage_RFID.TabIndex = 6;
            this.tabPage_RFID.Text = "RFID";
            this.tabPage_RFID.UseVisualStyleBackColor = true;
            // 
            // label_RFID_STATUS
            // 
            this.label_RFID_STATUS.AutoSize = true;
            this.label_RFID_STATUS.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_RFID_STATUS.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_RFID_STATUS.Location = new System.Drawing.Point(187, 93);
            this.label_RFID_STATUS.Name = "label_RFID_STATUS";
            this.label_RFID_STATUS.Size = new System.Drawing.Size(200, 12);
            this.label_RFID_STATUS.TabIndex = 3;
            this.label_RFID_STATUS.Text = "RFID Card Registration Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Registration Status :";
            // 
            // textBox_RFID_KEY1
            // 
            this.textBox_RFID_KEY1.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_RFID_KEY1.Location = new System.Drawing.Point(89, 39);
            this.textBox_RFID_KEY1.Name = "textBox_RFID_KEY1";
            this.textBox_RFID_KEY1.Size = new System.Drawing.Size(330, 26);
            this.textBox_RFID_KEY1.TabIndex = 1;
            this.textBox_RFID_KEY1.TextChanged += new System.EventHandler(this.textBox_RFID_KEY1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "RFID Key";
            // 
            // tabPage_ABS
            // 
            this.tabPage_ABS.Controls.Add(this.listView3);
            this.tabPage_ABS.Controls.Add(this.textBox_RFID_enter_date);
            this.tabPage_ABS.Controls.Add(this.textBox_RFID_phone);
            this.tabPage_ABS.Controls.Add(this.textBox_RFID_name);
            this.tabPage_ABS.Controls.Add(this.textBox_RFID_pos);
            this.tabPage_ABS.Controls.Add(this.textBox_RFID_depart);
            this.tabPage_ABS.Controls.Add(this.textBox_RFID_num);
            this.tabPage_ABS.Controls.Add(this.textBox_RFID_KEY2);
            this.tabPage_ABS.Controls.Add(this.label17);
            this.tabPage_ABS.Controls.Add(this.label16);
            this.tabPage_ABS.Controls.Add(this.label15);
            this.tabPage_ABS.Controls.Add(this.label14);
            this.tabPage_ABS.Controls.Add(this.label13);
            this.tabPage_ABS.Controls.Add(this.label12);
            this.tabPage_ABS.Controls.Add(this.label11);
            this.tabPage_ABS.Controls.Add(this.button_RFID_Clear);
            this.tabPage_ABS.Controls.Add(this.button_RFID_Whole);
            this.tabPage_ABS.Controls.Add(this.button_RFID_Each);
            this.tabPage_ABS.Controls.Add(this.button_RFID_Delete);
            this.tabPage_ABS.Controls.Add(this.button_RFID_Modify);
            this.tabPage_ABS.Controls.Add(this.button_RFID_Regist);
            this.tabPage_ABS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ABS.Name = "tabPage_ABS";
            this.tabPage_ABS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ABS.Size = new System.Drawing.Size(872, 278);
            this.tabPage_ABS.TabIndex = 7;
            this.tabPage_ABS.Text = "ABS";
            this.tabPage_ABS.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_RFID,
            this.columnHeader_NUM,
            this.columnHeader_DEPART,
            this.columnHeader_POS,
            this.columnHeader_NAME,
            this.columnHeader_PHONE,
            this.columnHeader_ENTER_DATE});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(232, 67);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(630, 188);
            this.listView3.TabIndex = 20;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_RFID
            // 
            this.columnHeader_RFID.Text = "RFID";
            this.columnHeader_RFID.Width = 175;
            // 
            // columnHeader_NUM
            // 
            this.columnHeader_NUM.Text = "NUM";
            this.columnHeader_NUM.Width = 76;
            // 
            // columnHeader_DEPART
            // 
            this.columnHeader_DEPART.Text = "DEPART";
            this.columnHeader_DEPART.Width = 75;
            // 
            // columnHeader_POS
            // 
            this.columnHeader_POS.Text = "POSITION";
            this.columnHeader_POS.Width = 75;
            // 
            // columnHeader_NAME
            // 
            this.columnHeader_NAME.Text = "NAME";
            this.columnHeader_NAME.Width = 75;
            // 
            // columnHeader_PHONE
            // 
            this.columnHeader_PHONE.Text = "MOBILE";
            this.columnHeader_PHONE.Width = 75;
            // 
            // columnHeader_ENTER_DATE
            // 
            this.columnHeader_ENTER_DATE.Text = "ENTER DATE";
            this.columnHeader_ENTER_DATE.Width = 75;
            // 
            // textBox_RFID_enter_date
            // 
            this.textBox_RFID_enter_date.Location = new System.Drawing.Point(120, 234);
            this.textBox_RFID_enter_date.Name = "textBox_RFID_enter_date";
            this.textBox_RFID_enter_date.Size = new System.Drawing.Size(100, 21);
            this.textBox_RFID_enter_date.TabIndex = 19;
            // 
            // textBox_RFID_phone
            // 
            this.textBox_RFID_phone.Location = new System.Drawing.Point(120, 206);
            this.textBox_RFID_phone.Name = "textBox_RFID_phone";
            this.textBox_RFID_phone.Size = new System.Drawing.Size(100, 21);
            this.textBox_RFID_phone.TabIndex = 18;
            // 
            // textBox_RFID_name
            // 
            this.textBox_RFID_name.Location = new System.Drawing.Point(120, 178);
            this.textBox_RFID_name.Name = "textBox_RFID_name";
            this.textBox_RFID_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_RFID_name.TabIndex = 17;
            // 
            // textBox_RFID_pos
            // 
            this.textBox_RFID_pos.Location = new System.Drawing.Point(120, 151);
            this.textBox_RFID_pos.Name = "textBox_RFID_pos";
            this.textBox_RFID_pos.Size = new System.Drawing.Size(100, 21);
            this.textBox_RFID_pos.TabIndex = 16;
            // 
            // textBox_RFID_depart
            // 
            this.textBox_RFID_depart.Location = new System.Drawing.Point(120, 123);
            this.textBox_RFID_depart.Name = "textBox_RFID_depart";
            this.textBox_RFID_depart.Size = new System.Drawing.Size(100, 21);
            this.textBox_RFID_depart.TabIndex = 15;
            // 
            // textBox_RFID_num
            // 
            this.textBox_RFID_num.Location = new System.Drawing.Point(120, 95);
            this.textBox_RFID_num.Name = "textBox_RFID_num";
            this.textBox_RFID_num.Size = new System.Drawing.Size(100, 21);
            this.textBox_RFID_num.TabIndex = 14;
            // 
            // textBox_RFID_KEY2
            // 
            this.textBox_RFID_KEY2.Location = new System.Drawing.Point(120, 67);
            this.textBox_RFID_KEY2.Name = "textBox_RFID_KEY2";
            this.textBox_RFID_KEY2.Size = new System.Drawing.Size(100, 21);
            this.textBox_RFID_KEY2.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 12);
            this.label17.TabIndex = 12;
            this.label17.Text = "Enter Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "Mobile Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 12);
            this.label14.TabIndex = 9;
            this.label14.Text = "Position";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "Depart";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "Member Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "RFID";
            // 
            // button_RFID_Clear
            // 
            this.button_RFID_Clear.Location = new System.Drawing.Point(620, 18);
            this.button_RFID_Clear.Name = "button_RFID_Clear";
            this.button_RFID_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_RFID_Clear.TabIndex = 5;
            this.button_RFID_Clear.Text = "Clear";
            this.button_RFID_Clear.UseVisualStyleBackColor = true;
            this.button_RFID_Clear.Click += new System.EventHandler(this.button_RFID_Clear_Click);
            // 
            // button_RFID_Whole
            // 
            this.button_RFID_Whole.Location = new System.Drawing.Point(520, 18);
            this.button_RFID_Whole.Name = "button_RFID_Whole";
            this.button_RFID_Whole.Size = new System.Drawing.Size(75, 23);
            this.button_RFID_Whole.TabIndex = 4;
            this.button_RFID_Whole.Text = "Whole";
            this.button_RFID_Whole.UseVisualStyleBackColor = true;
            this.button_RFID_Whole.Click += new System.EventHandler(this.button_RFID_Whole_Click);
            // 
            // button_RFID_Each
            // 
            this.button_RFID_Each.Location = new System.Drawing.Point(420, 18);
            this.button_RFID_Each.Name = "button_RFID_Each";
            this.button_RFID_Each.Size = new System.Drawing.Size(75, 23);
            this.button_RFID_Each.TabIndex = 3;
            this.button_RFID_Each.Text = "Each";
            this.button_RFID_Each.UseVisualStyleBackColor = true;
            this.button_RFID_Each.Click += new System.EventHandler(this.button_RFID_Each_Click);
            // 
            // button_RFID_Delete
            // 
            this.button_RFID_Delete.Location = new System.Drawing.Point(320, 18);
            this.button_RFID_Delete.Name = "button_RFID_Delete";
            this.button_RFID_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_RFID_Delete.TabIndex = 2;
            this.button_RFID_Delete.Text = "Delete";
            this.button_RFID_Delete.UseVisualStyleBackColor = true;
            this.button_RFID_Delete.Click += new System.EventHandler(this.button_RFID_Delete_Click);
            // 
            // button_RFID_Modify
            // 
            this.button_RFID_Modify.Location = new System.Drawing.Point(220, 18);
            this.button_RFID_Modify.Name = "button_RFID_Modify";
            this.button_RFID_Modify.Size = new System.Drawing.Size(75, 23);
            this.button_RFID_Modify.TabIndex = 1;
            this.button_RFID_Modify.Text = "Modify";
            this.button_RFID_Modify.UseVisualStyleBackColor = true;
            this.button_RFID_Modify.Click += new System.EventHandler(this.button_RFID_Modify_Click);
            // 
            // button_RFID_Regist
            // 
            this.button_RFID_Regist.Location = new System.Drawing.Point(120, 18);
            this.button_RFID_Regist.Name = "button_RFID_Regist";
            this.button_RFID_Regist.Size = new System.Drawing.Size(75, 23);
            this.button_RFID_Regist.TabIndex = 0;
            this.button_RFID_Regist.Text = "Regist";
            this.button_RFID_Regist.UseVisualStyleBackColor = true;
            this.button_RFID_Regist.Click += new System.EventHandler(this.button_RFID_Regist_Click);
            // 
            // tabPage_Exit
            // 
            this.tabPage_Exit.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Exit.Name = "tabPage_Exit";
            this.tabPage_Exit.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Exit.Size = new System.Drawing.Size(872, 278);
            this.tabPage_Exit.TabIndex = 5;
            this.tabPage_Exit.Text = "Exit";
            this.tabPage_Exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "AIR CONDITIONING, ABSENTEEISM AND TARDINESS MANAGEMENT SYSTEM";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ver 1.0.0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 387);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Smart_Factory";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Setup.ResumeLayout(false);
            this.tabPage_Setup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Monitoring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage_History.ResumeLayout(false);
            this.tabPage_History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage_RFID.ResumeLayout(false);
            this.tabPage_RFID.PerformLayout();
            this.tabPage_ABS.ResumeLayout(false);
            this.tabPage_ABS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Setup;
        private System.Windows.Forms.TabPage tabPage_Monitoring;
        private System.Windows.Forms.TabPage tabPage_History;
        private System.Windows.Forms.TabPage tabPage_Control;
        private System.Windows.Forms.TabPage tabPage_Warehouse;
        private System.Windows.Forms.TabPage tabPage_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BPS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.ProgressBar progressBar_PortStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ComPort;
        private System.Windows.Forms.Button button_ClosePort;
        private System.Windows.Forms.Button button_OpenPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_ReceiveData;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_SendData;
        private System.Windows.Forms.TabPage tabPage_RFID;
        private System.Windows.Forms.TabPage tabPage_ABS;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label LB_RFIDDBStatus;
        private System.Windows.Forms.Label LB_SensorDBStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_TEMP;
        private System.Windows.Forms.ColumnHeader columnHeader_WET;
        private System.Windows.Forms.ColumnHeader columnHeader_TIME;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader_HISTORY_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_HISTORY_TEMP;
        private System.Windows.Forms.ColumnHeader columnHeader_HISTORY_WET;
        private System.Windows.Forms.ColumnHeader columnHeader_HISTORY_TIME;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TOTIME;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TODATE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FROMTIME;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FROMDATE;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_RFID_STATUS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_RFID_KEY1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader_RFID;
        private System.Windows.Forms.ColumnHeader columnHeader_NUM;
        private System.Windows.Forms.ColumnHeader columnHeader_DEPART;
        private System.Windows.Forms.ColumnHeader columnHeader_POS;
        private System.Windows.Forms.ColumnHeader columnHeader_NAME;
        private System.Windows.Forms.ColumnHeader columnHeader_PHONE;
        private System.Windows.Forms.ColumnHeader columnHeader_ENTER_DATE;
        private System.Windows.Forms.TextBox textBox_RFID_enter_date;
        private System.Windows.Forms.TextBox textBox_RFID_phone;
        private System.Windows.Forms.TextBox textBox_RFID_name;
        private System.Windows.Forms.TextBox textBox_RFID_pos;
        private System.Windows.Forms.TextBox textBox_RFID_depart;
        private System.Windows.Forms.TextBox textBox_RFID_num;
        private System.Windows.Forms.TextBox textBox_RFID_KEY2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_RFID_Clear;
        private System.Windows.Forms.Button button_RFID_Whole;
        private System.Windows.Forms.Button button_RFID_Each;
        private System.Windows.Forms.Button button_RFID_Delete;
        private System.Windows.Forms.Button button_RFID_Modify;
        private System.Windows.Forms.Button button_RFID_Regist;
        private System.Windows.Forms.ColumnHeader columnHeader_DHT11_TEMP;
        private System.Windows.Forms.ColumnHeader columnHeader_DHT11_WET;
        private System.Windows.Forms.ColumnHeader columnHeader_HISTORY_DHT11_TEMP;
        private System.Windows.Forms.ColumnHeader columnHeader_HISTORY_DHT11_WET;
    }
}

