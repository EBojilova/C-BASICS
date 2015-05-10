using System;

class CalculateGCD
{
    static void Main()
    {
        int a,b = new int();
        Console.Write("a: ");
        string aStr = Console.ReadLine();
        if (!int.TryParse(aStr, out a))
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("b: ");
        string bStr = Console.ReadLine();
        if (!int.TryParse(bStr, out b))
        {
            Console.WriteLine("out of range");
            return;
        }
        if (a != 0 && b != 0)
        {
           
            int max = Math.Max(Math.Abs(a), Math.Abs(b));
            int min = Math.Min(Math.Abs(a), Math.Abs(b));
            int reminder = 1;
            while (reminder != 0)
            {
                reminder = max % min;
                max = min;
                min = reminder;
            }
            Console.WriteLine(max);
        }
        else
        {
            Console.WriteLine("GCD(a, b) is Math.Abs() of the nummber, dfferent from 0");
        }
    }
}

