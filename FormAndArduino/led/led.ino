#include <U8g2lib.h>
#include <U8x8lib.h>

 const  int LedPin = 13;
 int ledState = 0;
void setup() {
  // put your setup code here, to run once:

pinMode(LedPin, OUTPUT);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
char receiveVal;
if (Serial.available() > 0)
{
  
  receiveVal = Serial.read();

  if (receiveVal == '1')
      ledState = 1;
else 
  ledState = 0;

}
digitalWrite(LedPin, ledState);
delay(50);
}
