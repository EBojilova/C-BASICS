/*
Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. Examples:

n			IsPrime(n)
0				false
1				false
2				true
3				true
4				false
5				true
323				false
337				true
6737626471		true
117342557809	false
*/
using System;

class PrimeChecker
{
    static bool IsPrime(long number)
    {
        if (number < 2 || (number > 2 && number % 2 == 0))
            return false;
        long lastToCheck = (long)Math.Sqrt(number);

        for (long i = 3; i <= lastToCheck; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine("{0} is {1}", n, IsPrime(n) ? "prime" : "not prime");
    }
}