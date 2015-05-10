using System;

class NumbersInInterval
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0}, ",i);
            }
        }
    }
}

