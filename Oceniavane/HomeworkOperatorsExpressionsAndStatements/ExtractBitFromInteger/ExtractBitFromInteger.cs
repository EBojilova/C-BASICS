using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit position: ");
        int n = int.Parse(Console.ReadLine());

        int nRightnumber = number >> n;
        int bit = nRightnumber & 1;
        Console.WriteLine("The bit on position {0} is {1}.", n, bit);
    }
}
