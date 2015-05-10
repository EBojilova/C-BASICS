using System;

class SumOfNNumbers
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= input; i++)
        {
            Console.Write("Number {0} - ", i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum - {0}", sum);
    }
}

