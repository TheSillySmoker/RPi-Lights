import RPi.GPIO as GPIO
import time
ledPin = 21
GPIO.setmode(GPIO.BCM)
GPIO.setup(ledPin, GPIO.OUT)

x = 1
while x == 1:
    var = raw_input("On or Off? Please enter: ")
    if var == "On":
        GPIO.output(ledPin, GPIO.HIGH)
    elif var == "Off":
        GPIO.output(ledPin, GPIO.LOW)
    else:
        print("Please enter either 'On' or 'Off'.")

            
