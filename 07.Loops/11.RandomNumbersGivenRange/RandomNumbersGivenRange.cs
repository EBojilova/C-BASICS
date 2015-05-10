using System;

class RandomNumbersGivenRange
{
    static void Main()
    {
        int n, min, max = new int();
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (int.TryParse(nStr, out n)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("min: ");
        string minStr = Console.ReadLine();
        if (int.TryParse(minStr, out min)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("max: ");
        string maxStr = Console.ReadLine();
        if (int.TryParse(maxStr, out max)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Random generatorNums = new Random();
        for (int i = 1; i <= n; i++)
        {
            int numI = generatorNums.Next(min, max + 1);
            Console.Write("{0} ", numI);
        }
    }
}

