using System;
using System.Runtime.InteropServices;

class SumOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("SumOf3Numbers = {0}",  a + b + c);
    }
}