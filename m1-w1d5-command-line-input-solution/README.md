# Command Line Exercises

## Decimal to Binary

Write a command line program which prompts the user for a series of decimal integer values  
and displays each decimal value as itself and its binary equivalent

```
Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321

460 in binary is 111001100
8218 in binary is 10000000011010
1 in binary is 1
31313 in binary is 111101001010001
987654321 in binary is 111010110111100110100010110001
```

## Fibonacci

The Fibonacci numbers are the integers in the following sequence:  

    0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
 
By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number. 
  

```
Please enter the Fibonacci number: 25

0, 1, 1, 2, 3, 5, 8, 13, 21
``` 
 
## Linear Convert

Write a program that converts meters to feet and vice-versa.

The foot to meter conversion formula is:
    
    m = f * 0.3048

The meter to foot conversion formula is:
    
    f = m * 3.2808399

Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
Convert the length to the opposite measurement, and display the old and new measurements to the console.

```
Please enter the length: 58
Is the measurement in (m)eter, or (f)eet? f
58f is 17m.
```
    
## Temperature Convert

The Fahrenheit to Celsius conversion formula is:

    Tc = (Tf - 32) / 1.8

where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit

The Celsius to Fahrenheit conversion formula is:

    Tf = Tc * 1.8 + 32

Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

```
Please enter the temperature: 58 <br/>
Is the temperature in (C)elcius, or (F)arenheit? F <br/>
58F is 14C.
```


## Make Change

Write a command line program which prompts the user for the total bill, and the amount tendered. It should then display the change required.

```    
Please enter the amount of the bill: 23.65 <br/>
Please enter the amount tendered: 100.00 <br/>
The change required is 76.35
```

## Martian Weight

In case you've ever pondered how much you weight on Mars, here's the calculation:

    Wm = We* 0.378

where 'Wm' is the weight on Mars, and 'We' is the weight on Earth

Write a command line program which accepts a series of Earth weights from the user  
and displays each Earth weight as itself, and its Martian equivalent.

``` 
Enter a series of Earth weights (space-separated): 98 235 185

98 lbs.on Earth, is 37 lbs.on Mars. 
235 lbs.on Earth, is 88 lbs.on Mars.
185 lbs.on Earth, is 69 lbs.on Mars. 
```     