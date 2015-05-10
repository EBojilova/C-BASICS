using System;

class NumbersIntervalDividableGivenNumber
{
    static void Main()
    {
        int start, end = new int();
        Console.Write("start: ");
        string startStr = Console.ReadLine();
        if (!int.TryParse(startStr, out start))
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("end: ");
        string endStr = Console.ReadLine();
        if (!int.TryParse(endStr, out end))
        {
            Console.WriteLine("out of range");
            return;
        }
        int k = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0} ", i);
                k++;
            }
            
        }
        Console.WriteLine();
        Console.WriteLine(k);
    }
}

