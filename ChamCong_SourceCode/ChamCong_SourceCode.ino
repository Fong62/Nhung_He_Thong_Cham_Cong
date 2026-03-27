  #include <SPI.h>
  #include <MFRC522.h>
  #include <LiquidCrystal_I2C.h>
  LiquidCrystal_I2C lcd(0x27, 16, 2);
  
  #define SS_PIN 10
  #define RST_PIN 9
  #define LED_G 3 //define green LED pin
  #define LED_R 4 //define red LED
  #define BUZZER_PIN 5

  MFRC522 mfrc522(SS_PIN, RST_PIN);   // Create MFRC522 instance.

  bool cardCheck = false;

  void setup() 
  {
    Serial.begin(9600);
    SPI.begin();      // Initiate  SPI bus
    mfrc522.PCD_Init();   // Initiate MFRC522
    
    pinMode(LED_G, OUTPUT);
    pinMode(LED_R, OUTPUT);
    pinMode(A0, OUTPUT);
    pinMode(BUZZER_PIN, OUTPUT);
  
    Wire.begin(); // Join I2C bus (using A4, A5) 
    lcd.init(); 
    lcd.backlight();
  }
  void loop() 
  {
    // Look for new cards
    if ( ! mfrc522.PICC_IsNewCardPresent()) 
    {
      return;
    }
    // Select one of the cards
    if ( ! mfrc522.PICC_ReadCardSerial()) 
    {
      return;
    }

    if (!cardCheck) {  // Chỉ xử lý nếu thẻ chưa được quét
        cardCheck = true;  // Đánh dấu thẻ đã quét

        String content= "";
        byte letter;
        for (byte i = 0; i < mfrc522.uid.size; i++) 
        {
        content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
        content.concat(String(mfrc522.uid.uidByte[i], HEX));
        }

        content.toUpperCase();
        Serial.println(content.substring(1));
    }
    
    char response = 0;

    if (Serial.available() > 0) {
        response = Serial.read();
        if (response == '1')
        {
          digitalWrite(LED_G, HIGH);
          digitalWrite(A0, HIGH);
          tone(BUZZER_PIN, 2000);
          delay(1000);
          digitalWrite(LED_G, LOW);
          digitalWrite(A0, LOW);
          noTone(BUZZER_PIN);
          
          lcd.setCursor(0, 0);
          lcd.print("Diem danh thanh cong");
          for (int i = 0; i < 10; i++) { // Scroll 16 times 
          lcd.scrollDisplayLeft(); 
          delay(300); // Adjust the delay to control the speed of scrolling 
          }
          delay(500);
          lcd.clear();
        }
        else{
          digitalWrite(LED_R, HIGH);
          digitalWrite(A0, HIGH);
          tone(BUZZER_PIN, 2000);
          delay(2000);
          digitalWrite(LED_R, LOW);
          digitalWrite(A0, LOW);
          noTone(BUZZER_PIN);
          lcd.setCursor(0, 0);
          lcd.print("Diem danh khong thanh cong");
          for (int i = 0; i < 10; i++) { // Scroll 16 times 
            lcd.scrollDisplayLeft(); 
            delay(300); // Adjust the delay to control the speed of scrolling 
          }
          delay(500);
          lcd.clear(); 
        }
      cardCheck = false;
    }
  } 

