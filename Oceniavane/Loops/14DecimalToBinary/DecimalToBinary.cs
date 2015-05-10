using System;
using System.Collections.Generic;
class DecimalToBinary
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint tempSum = 0;
        List<string> array = new List<string>();

        if (n == 0)
        {
            Console.WriteLine(n);
            return;
        }

        while (n != 0)
        {
            tempSum = n;
            tempSum = tempSum % 2;
            n = n / 2;

            array.Add(tempSum.ToString());
        }

        array.Reverse();

        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}