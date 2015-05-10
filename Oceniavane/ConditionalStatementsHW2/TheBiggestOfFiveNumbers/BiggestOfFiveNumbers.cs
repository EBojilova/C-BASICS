
/*Problem 6.	The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only
five if statements. Examples:
a	    b	    c	    d	    e	    biggest
5	    2	    2	    4	    1	    5
-2	    -22	    1	    0	    0	    1
-2	    4	    3	    2	    0	    4
0	    -2.5	0	    5	    5	    5
-3	    -0.5	-1.1	-2	    -0.1	-0.1*/



using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter a number a and press key enter, a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter a number b and press key enter, b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter a number c and press key enter, c = ");
        float c = float.Parse(Console.ReadLine());
        Console.Write("Enter a number d and press key enter, d = ");
        float d = float.Parse(Console.ReadLine());
        Console.Write("Enter a number e and press key enter, e = ");
        float e = float.Parse(Console.ReadLine());
        float tempVar = 0;
        if (a > b && a > c && a > d && a > e)
        {
            tempVar = a;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4} biggest is {5}",
                                a, b, c, d, e, tempVar);
        }
        else if (b > a && b > c && b > d && b > e)
        {
            tempVar = b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4} biggest is {5}",
                               a, b, c, d, e, tempVar);
        }
        else if (c > a && c > b && c > d && c > e)
        {
            tempVar = c;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4} biggest is {5}",
                               a, b, c, d, e, tempVar);
        }
        else if (d > a && d > b && d > c && d > e)
        {
            tempVar = d;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4} biggest is {5}",
                               a, b, c, d, e, tempVar);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            tempVar = e;
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}, e = {4} biggest is {5}",
                               a, b, c, d, e, tempVar);
        }
        else
        {
            tempVar = a;
            Console.WriteLine("a = b = c = d = e = {0}", tempVar);
        }
    }
}

