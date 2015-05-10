using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int n = int.Parse(Console.ReadLine());
        bool oddNumber = (Math.Abs(n % 2) == 1 ? true : false);
        Console.WriteLine(oddNumber);
    }
}

