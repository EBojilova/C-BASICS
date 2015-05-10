using System;

internal class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double nNew = double.Parse(Console.ReadLine());
            sum += nNew;
        }
        Console.WriteLine(sum);
    }
}