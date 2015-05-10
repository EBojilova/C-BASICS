

/*Problem 4.	Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real
numbers, without calculating it. Use a sequence of if operators. Examples:
a	    b	    c	    result
5	    2	    2	    +
-2	    -2	    1	    +
-2	    4	    3	    -
0	    -2.5	4	    0
-1	    -0.5	-5.1	-*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number a and press key enter, a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter number b and press key enter, b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter number c and press key enter, c = ");
        float c = float.Parse(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, result: +", a, b, c);
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, result: +", a, b, c);
        }
        else if (a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, result: -", a, b, c);
        }
        else if (a == 0 && b < 0 && c > 0)
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, result: 0", a, b, c);
        }
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, result: -", a, b, c);
        }
        else
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, result: {3}", a, b, c, (a*b*c));
        }
    }
}

