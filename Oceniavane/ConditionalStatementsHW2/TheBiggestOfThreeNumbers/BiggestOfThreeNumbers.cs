
/*Problem 5.	The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers. Examples:
a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5	5	    5
-0.1	-0.5	-1.1	-0.1*/



using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter a number a and press key enter, a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter a number b and press key enter, b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter a number c and press key enter, c = ");
        float c = float.Parse(Console.ReadLine());
        float tempVar = 0;
        if (a > b && a > c)
        {
            tempVar = a;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, biggest is {3}",
                               a, b, c, tempVar);
        }
        else if (b > a && b > c)
        {
            tempVar = b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, biggest is {3}",
                               a, b, c, tempVar);
        }
        else if (c > a && c > b)
        {
            tempVar = c;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, biggest is {3}",
                               a, b, c, tempVar);
        }
        else
        {
            tempVar = a;
            Console.WriteLine("a = b = c = {0}", tempVar);
        }
    }
}

