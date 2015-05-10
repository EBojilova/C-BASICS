using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        bool IsOne = false;
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit position: ");
        int n = int.Parse(Console.ReadLine());

        int nRightnumber = number >> n;
        int bit = nRightnumber & 1;
        if(bit == 1)
        {
            IsOne = true;
        }
        Console.WriteLine("The bit on position {0} is 1." + IsOne, n);
    }
}

