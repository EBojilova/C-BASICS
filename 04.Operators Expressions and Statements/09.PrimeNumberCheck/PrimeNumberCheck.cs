using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int k = 0;
        Console.WriteLine("Please enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                k++;
            }
        }
        Console.WriteLine(k == 2);
    }
}

/*using System;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int number;
            string numberString = Console.ReadLine();
            if (!Int32.TryParse(numberString, out number))
            {
                Console.Write("Not a number or integer number !");
                return;
            }
            bool isPrime = !((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 7 == 0));
            Console.WriteLine(isPrime);
        }
    }
}*/