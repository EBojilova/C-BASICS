using System;

class BitSifting
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));
        for (int i = 0; i < n; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine());
            number &= ~sieve;
        }
        int counter = 0;
        while (number > 0)
        {
            counter += (int)(number) & 1;
            number >>= 1;
        }
        Console.WriteLine(counter);
    }
}
