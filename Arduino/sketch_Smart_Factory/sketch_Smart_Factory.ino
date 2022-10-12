/* ============================================================================ *
 * | ARDUINO | RFID | PIEZO | DHT11 | POTENTIOMETER_1 | POTENTIOMETER_2 | LED | *
 * ---------------------------------------------------------------------------- *
 * | 5V      |      |       |       | +               | +               |     | *
 * | 3.3V    | 3.3V |       | +     |                 |                 |     | *
 * | GND     | GND  | GND   | GND   | GND             | GND             | GND | *
 * | A0      |      |       |       | OUT             |                 |     | *
 * | A1      |      |       |       |                 | OUT             |     | *
 * | A2      |      |       |       |                 |                 |     | *
 * | A3      |      |       |       |                 |                 |     | *
 * | A4      |      |       |       |                 |                 |     | *
 * | A5      |      |       |       |                 |                 |     | *
 * | D0      |      |       |       |                 |                 |     | *
 * | D1      |      |       |       |                 |                 |     | *
 * | D2      |      |       |       |                 |                 |     | *
 * | D3      |      |       |       |                 |                 |     | *
 * | D4      |      |       |       |                 |                 |     | *
 * | D5      |      |       |       |                 |                 |     | *
 * | D6      |      |       |       |                 |                 | IN  | *
 * | D7      |      |       | OUT   |                 |                 |     | *
 * | D8      |      | +     |       |                 |                 |     | *
 * | D9      | RST  |       |       |                 |                 |     | *
 * | D10     | SDA  |       |       |                 |                 |     | *
 * | D11     | MOSI |       |       |                 |                 |     | *
 * | D12     | MISO |       |       |                 |                 |     | *
 * | D13     | SCK  |       |       |                 |                 |     | *
 * ============================================================================ */
#include <SPI.h>
#include <MFRC522.h>
#include <DHT11.h>
#include <arduino-timer.h>
#define SS_PIN 10
#define RST_PIN 9
#define PIEZO 8
#define DHT11_PIN 7
#define YELLOW_LED 6
DHT11 dht11(DHT11_PIN);
MFRC522 rfid(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;
auto timer = timer_create_default(); // TIMER INSTANCE
bool end_message_detect_flag = 0;
byte nuidPICC[4];
int current_value[4];
int desire_value[2]= {4, 20};
String rxStr = "";
String serial_in;
volatile int led_on = 0;
volatile int timer_counter = 0; // 2000ms
volatile int timer_sensor = 0; // 2000ms
volatile int rfid_card_contact = 0;
void read_sensor_value();
bool timer_10ms (void *) {
  timer_counter++;
  timer_sensor++;
  // 10ms * 50 = 500ms
  if (timer_counter >= 50) {
    timer_counter = 0;
    digitalWrite(13, !digitalRead(13));
  }
  rfid_card_contact = 1;
  if (rfid_card_contact >= 10){
    rfid_card_contact = 0;
  }
  return true;
}
void setup() {
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  SPI.begin();
  rfid.PCD_Init();
  for (byte i = 0; i < 6; i++) {
    key.keyByte[i] = 0xFF;
  }
  printHex(key.keyByte, MFRC522::MF_KEY_SIZE);
  Serial.println();
  timer.every(10, timer_10ms);
}
void loop() {
  read_sensor_value();
  timer.tick();
  if (!rfid.PICC_IsNewCardPresent())
    return;
  if (!rfid_card_contact) {
    rfid_card_contact = 1;
  }
  if (!rfid.PICC_ReadCardSerial()) {
    return;
  }
  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);
  if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&  
      piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
      piccType != MFRC522::PICC_TYPE_MIFARE_4K) {
    return;
  }
  for (byte i = 0; i < 4; i++) {
  nuidPICC[i] = rfid.uid.uidByte[i];
  }
  Serial.print(F("[RFID]:"));
  printHex(rfid.uid.uidByte, rfid.uid.size);
  Serial.println();
  tone(PIEZO, 1000, 500);  
  rfid.PICC_HaltA();
  rfid.PCD_StopCrypto1();
}
void printHex(byte *buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; i++) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], HEX);
  }
}
void read_sensor_value() {
  int err;
  float dht11_temp, dht11_wet;
  // 10ms * 100 = 1000ms
  if (timer_sensor >= 100) {
    timer_sensor = 0;
    current_value[0] = map(analogRead(A0), 0, 1023, 0, 40); // TEMPERATURE
    current_value[1] = map(analogRead(A1), 0, 1023, 0, 100); // HUMIDITY
    if((err = dht11.read(dht11_wet, dht11_temp)) == 0) {
      current_value[2] = (int)dht11_temp;
      current_value[3] = (int)dht11_wet;
    }
    Serial.print("[TMP]:" + (String)current_value[0] + "\n");
    Serial.print("[WET]:" + (String)current_value[1] + "\n");
    Serial.print("[DHT11 TMP]:" + (String)current_value[2] + "\n");
    Serial.print("[DHT11 WET]:" + (String)current_value[3] + "\n");
  }
}
