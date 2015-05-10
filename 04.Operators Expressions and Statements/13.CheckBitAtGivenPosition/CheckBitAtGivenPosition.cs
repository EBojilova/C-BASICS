using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("p: ");
        int p = Convert.ToInt32(Console.ReadLine());
        int nRigthP = n >> p;
        int bit = nRigthP & 1;
        Console.WriteLine(bit == 1);
    }
}

