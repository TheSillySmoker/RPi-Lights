import RPi.GPIO as GPIO
import time
import sys
ledPin = 21
GPIO.setmode(GPIO.BCM)
GPIO.setup(ledPin, GPIO.OUT)

x = 1
while x == 1:
    var = raw_input("On or Off? Please enter: ")
    if var == "On":
        GPIO.output(ledPin, GPIO.HIGH)
        print("The LED is now " + var + "! Type 'Exit' to close program.")
    elif var == "Off":
        GPIO.output(ledPin, GPIO.LOW)
        print("The LED is now " + var + "! Type 'Exit' to close program.")
    elif var == "Exit":
        sys.exit()
    else:
        print("Please enter either 'On' or 'Off'.")

            
