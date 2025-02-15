## Arduino サンプルコード

```c
int LED_PIN = 2;

void setup() {
  Serial.begin(9600);

  pinMode(LED_PIN, OUTPUT);
  digitalWrite(LED_PIN, HIGH);
}

void loop() {
  if (Serial.available()) {
    char data = Serial.read();
    Serial.write(data);

    if (data == '0') {
      digitalWrite(2, HIGH);
    } else if (data == '1') {
      digitalWrite(2, LOW);
    }
  }
}
```
