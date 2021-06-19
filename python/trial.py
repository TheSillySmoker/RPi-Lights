import RPi.GPIO as GPIO
import time
ledPin = 21
GPIO.setmode(GPIO.BCM)
GPIO.setup(ledPin, GPIO.OUT)

var = input("On or Off? Please enter: ")
if var == "On":
    GPIO.setmode(GPIO.BCM)
    GPIO.setup(ledPin, GPIO.OUT)
    GPIO.output(ledPin, GPIO.HIGH)

elif var == "Off":
    GPIO.output(ledPin, GPIO.LOW)
else:
    print("Please enter either 'On' or 'Off'.")

        

