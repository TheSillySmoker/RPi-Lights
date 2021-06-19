import RPi.GPIO as GPIO
import time
ledPin = 21
GPIO.setmode(GPIO.BCM)
GPIO.setup(ledPin, GPIO.OUT)
GPIO.output(ledPin, GPIO.HIGH)


var = str(input("On or Off? Please enter: "))
print(var)
time.sleep(1)
print(var)
time.sleep(1)

var1 = str(input("On or Off? Please enter: "))
"""
if var == "On":

    GPIO.output(ledPin, GPIO.HIGH)
    time.sleep(1)

elif var == "Off":
    GPIO.output(ledPin, GPIO.LOW)
else:
    print("Please enter either 'On' or 'Off'.")

        
"""