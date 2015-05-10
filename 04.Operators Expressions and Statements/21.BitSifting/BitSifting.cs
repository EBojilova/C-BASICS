using System;

class BitSifting
{
    static void Main(string[] args)
    {
        //ulong maxLong = ulong.MaxValue;
        //Console.WriteLine(maxLong);
        long bitsToSieve = (long)ulong.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(bitsToSieve, 2).PadLeft(64, '0'));
        int numberOfSieves = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfSieves; i++)
        {
            long sieveI = (long)ulong.Parse(Console.ReadLine());
            //With ~ it makes the 1 to 0 of the sieve and stops the 1 form the bitsToSieve with &)
            bitsToSieve &= ~sieveI;
            Console.WriteLine(Convert.ToString(sieveI, 2).PadLeft(64, '0'));
            Console.WriteLine(Convert.ToString(bitsToSieve, 2).PadLeft(64, '0'));
        }
        int counter = 0;
        string bitsToString = Convert.ToString(bitsToSieve, 2).PadLeft(64, '0');
        for (int i = 0; i < bitsToString.Length; i++)
        {
            if (bitsToString[i] == '1')
            {
                counter++;
            }

        }
        Console.WriteLine(counter);
    }
}

