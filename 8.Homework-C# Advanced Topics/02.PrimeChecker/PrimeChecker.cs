using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine((IsPrime(n)).ToString().ToLower());
    }

    public static bool IsPrime(long number)
    {
        if (number == 0 || number == 1)
        {
            return false;
        }
        for (long k = 2; k <= number; k++)
        {
            if (k < number && number % k == 0)
            {
                break;
            }
            else if (k >= Math.Ceiling(Math.Sqrt(number)) || number == k)
            {
                return true;
            }
        }
        return false;
    }
}

