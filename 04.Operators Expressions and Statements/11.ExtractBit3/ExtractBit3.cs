using System;

class ExtractBit3
{
    static void Main(string[] args)
    {
        int p = 3;
        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int nRigthP = n >> p;
        int bit = nRigthP & 1;
        Console.WriteLine(bit);
    }
}

