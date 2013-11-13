int motorPin = 5;
int redPin = 9;
int greenPin = 10;
int bluePin = 11;
int whitePin = 12;

void setup() 
{ 
  pinMode(motorPin, OUTPUT);


  pinMode(redPin, OUTPUT);
  pinMode(greenPin, OUTPUT);
  pinMode(bluePin, OUTPUT);  
  pinMode(whitePin, OUTPUT);

  Serial.begin(9600);
  while (! Serial);
  Serial.println("Speed 0 to 255");
  TCCR0B = TCCR0B & 0b11111000 | 0x01;
  //TCCR2B = TCCR2B & 0b11111000 | 0x01;
} 

void loop() 
{ 
  if (Serial.available())
  {
    int trigger = Serial.parseInt();
    Serial.println(trigger);
    if(trigger == 1)
    {
      lightningStrike();
    }
    else if(trigger == 2)
    {
      setColor(0,255,0);
    } 
    else if(trigger == 3)
    {
      setColor(255,185,0);
    } 
    else if(trigger == 4)
    {
      setColor(255,0,0);
    } 
    else if(trigger == 5)
    {
    } 
    else if (trigger >= 100 && trigger <= 255)
    {
      analogWrite(motorPin, trigger);
    }
  }
} 

void setColor(int red, int green, int blue)
{
  analogWrite(redPin, red);
  analogWrite(greenPin, green);
  analogWrite(bluePin, blue);  
}

void lightningStrike()
{
  digitalWrite(whitePin, HIGH);
  delay(20000);
  digitalWrite(whitePin, LOW);
}




