
/*Problem 7.	Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted
in descending order. Use nested if statements. Don’t use arrays and
the built-in sorting functionality. Examples:
a	    b	    c	    result
5	    1	    2	    5 2 1
-2	    -2	    1	    1 -2 -2
-2	    4	    3	    4 3 -2
0	    -2.5	5	    5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1*/



using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter number a and press key enter, a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter  number b and press key enter, b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter  number c and press key enter, c = ");
        float c = float.Parse(Console.ReadLine());
        if (a == b && a == c && b == c)
        {
            Console.WriteLine("result: a = b = c = {0}", a);
        }
        else if (a >= b && a >= c && b >= c)
        {
            Console.WriteLine("result: {0} {1} {2}", a, b, c);
        }
        else if (a >= b && a >= c && b <= c)
        {
            Console.WriteLine("result: {0} {1} {2}", a, c, b);
        }
        else if (b >= a && b >= c && a >= c)
        {
            Console.WriteLine("result: {0} {1} {2}", b, a, c);
        }
        else if (b >= a && b >= c && a <= c)
        {
            Console.WriteLine("result: {0} {1} {2}", b, c, a);
        }
        else if (c >= a && c >= b && a >= b)
        {
            Console.WriteLine("result: {0} {1} {2}", c, a, b);
        }
        else if (c >= a && c >= b && a <= b)
        {
            Console.WriteLine("result: {0} {1} {2}", c, b, a);
        }
    }
}
        
        

