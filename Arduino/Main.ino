
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    char c = Serial.read();
    Serial.write(c);
    Serial.println("");
    if(c == 'O')
      Serial.println("CMD TLT OPEN 1");
    else if(c == 'C')
      Serial.println("CMD TLT CLOSE 1");
      
    Serial.println("");
  }
}
