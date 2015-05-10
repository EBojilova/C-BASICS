
/*Problem 1.	Exchange If Greater
Write an if-statement that takes two integer variables a and b and exchanges
their values if the first one is greater than the second one. As a result print
the values a and b, separated by a space. Examples:
a	  b	    result
5	  2	    2 5
3	  4	    3 4
5.5	  4.5   4.5 5.5*/



using System;

class GreaterExchange
{
    static void Main()
    {
        Console.Write("Enter first variables a and press key Enter, a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter first variables b and press key Enter, b = ");
        float b = float.Parse(Console.ReadLine());
        if (a > b)
        {
            float tempVar = a;
            a = b;
            b = tempVar;
        }
        Console.WriteLine("result: {0} {1}", a, b);
    }
}

