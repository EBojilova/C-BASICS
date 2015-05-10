using System;
class CalculateN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        decimal sum = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += (factorial) / (decimal)(Math.Pow(x, i));
        }
        Console.WriteLine("{0:f5}", sum);
    }
}