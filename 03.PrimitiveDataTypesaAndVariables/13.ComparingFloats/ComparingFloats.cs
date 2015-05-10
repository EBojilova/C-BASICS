using System;

class ComparingFloats
{
    static void Main()
    {
        double n1;
        double n2;
        Console.WriteLine("Enter first double number n1:");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second double number n2:");
        n2 = double.Parse(Console.ReadLine());
        bool nearlyEqual = Math.Abs(n1 - n2) <= 0.000001;
        Console.WriteLine("The numbers are nearly equal: {0}", nearlyEqual);
    }
}
    
