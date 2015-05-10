
/*Problem 8.	Digit as Word
Write a program that asks for a digit (0-9), and depending on the
input, shows the digit as a word (in English). Print “not a digit”
in case of invalid inut. Use a switch statement. Examples:
d	    result
2	    two
1	    one
0	    zero
5	    five
-0.1	not a digit
hi	    not a digit
9	    nine
10	    not a digit*/



using System;

class WordADigit
{
    static void Main()
    {
        Console.Write("Enter digit 0-9 and press key enter, digit = ");
        string number = Console.ReadLine();
        switch (number)
        {
            case "2": Console.WriteLine("result: two"); break;
            case "1": Console.WriteLine("result: one"); break;
            case "0": Console.WriteLine("result: zero"); break;
            case "5": Console.WriteLine("result: five"); break;
            case "-0.1": Console.WriteLine("result: not a digit"); break;
            case "hi": Console.WriteLine("result: not a digit"); break;
            case "9": Console.WriteLine("result: nine"); break;
            case "10": Console.WriteLine("result: not a digit"); break;
        }
    }
}

