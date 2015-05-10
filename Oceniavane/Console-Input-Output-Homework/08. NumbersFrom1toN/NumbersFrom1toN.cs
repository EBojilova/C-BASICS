using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(i);
        }
    }
}
