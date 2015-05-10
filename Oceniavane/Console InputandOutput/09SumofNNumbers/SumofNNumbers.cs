using System;

class SumofNNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < a; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}