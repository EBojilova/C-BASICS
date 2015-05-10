using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Please enter a number between 0 and 100");
        int number = int.Parse(Console.ReadLine());
        if((number != 1) && (number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0))
        {
            Console.WriteLine("The number is prime!!!");
        }
        else
        {
            Console.WriteLine("The number is not prime!!!");
        }
    }
}

