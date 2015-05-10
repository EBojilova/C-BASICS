using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int Rightnumber = number >> 3;
        int bit = Rightnumber & 1;
        Console.WriteLine("The third bit is: {0}", bit);
    }
}

