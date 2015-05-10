using System;

internal class SumOf5Numbers
{
    static void Main()
    {
        string[] digits = Console.ReadLine().Split();
        double a = double.Parse(digits[0]);
        double b = double.Parse(digits[1]);
        double c = double.Parse(digits[2]);
        double d = double.Parse(digits[3]);
        double e = double.Parse(digits[4]);
        Console.WriteLine(a + b + c + d + e);
        
    }
}