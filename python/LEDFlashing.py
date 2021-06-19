import RPi.GPIO as GPIO
import time
ledPin = 21
GPIO.setmode(GPIO.BCM)
GPIO.setup(ledPin, GPIO.OUT)

x = 0
while x < 20:
    GPIO.output(ledPin, GPIO.HIGH)
    time.sleep(0.5)
    GPIO.output(ledPin, GPIO.LOW)
    time.sleep(0.5)
    x += 1
        




