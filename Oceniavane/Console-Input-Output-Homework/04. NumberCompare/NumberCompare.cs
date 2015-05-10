using System;

class NumberCompare
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("The larger number is: " + Math.Max(a,b));
    }
}

