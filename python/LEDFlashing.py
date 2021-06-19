import RPi.GPIO as GPIO
import time
ledPin = 21
GPIO.setmode(GPIO.BCM)
GPIO.setup(ledPin, GPIO.OUT)

x = 0
while x < 50:
    GPIO.output(ledPin, GPIO.HIGH)
    time.sleep(0.1)
    GPIO.output(ledPin, GPIO.LOW)
    time.sleep(0.3)
    x += 1
        




