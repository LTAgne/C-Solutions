# File I/O Part 2 Exercises

## FizzWriter

Create a program to write out the result of FizzBuzz (1 to 300) to a file called `FizzBuzz.txt`.

* If the number is divisible by 3 or contains a 3, print “Fizz”
* If the number is divisible by 5 or contains a 5, print “Buzz”
* If the number is divisible by 3 and 5, print “FizzBuzz”
* Otherwise print the number.

## File Splitter

#### Challenge

Develop an application that takes a significantly large input file and splits it into smaller file chunks.

**Step 1**

In order to determine how many files need to be produced, ask the user for the maximum amount of lines that
should appear in each file

```
How many lines of text (max) should there be in the split files? 100
```

Each file that is created should have a sequential number assigned to it.

For a 250 line input file "input.txt" this will produce 3 output files

* `input-1.txt` - 100 lines
* `input-2.txt` - 100 lines
* `input-3.txt` - 50 50 lines

Use a sequential naming format for each file produced to guarantee uniqueness.


These types of files use to be used quite common back in the earlier days of computing when disks such as floppies were much smaller and couldn’t hold a larger program on their own.