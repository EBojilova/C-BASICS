using System;

class CompaundInterest
{
    static void Main(string[] args)
    {
        decimal p = decimal.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        decimal i = decimal.Parse(Console.ReadLine());
        decimal f = decimal.Parse(Console.ReadLine());
        decimal bankOffer = (1 + i);
        for (int j = 1; j < n; j++)
        {
            bankOffer *= (1 + i);
        }
        bankOffer *= p;
        decimal friendOffer = p * (1+f);
        if (friendOffer<=bankOffer)
        {
            Console.WriteLine("{0:F2} {1}", friendOffer, "Friend");
        }
        else
        {
            Console.WriteLine("{0:F2} {1}", bankOffer, "Bank");
        }
    }
}
