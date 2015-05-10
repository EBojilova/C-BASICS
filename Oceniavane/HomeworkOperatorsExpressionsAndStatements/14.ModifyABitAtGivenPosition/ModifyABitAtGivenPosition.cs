using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        int mask;
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter p = ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Enter v = ");
        int v = int.Parse(Console.ReadLine());

        if (v == 1)
        {
            mask = ~(0 << p);
        }
        else
        {
            mask = ~(1 << p);
        }

        int result = n & mask;
        Console.WriteLine(result);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
    }
}
