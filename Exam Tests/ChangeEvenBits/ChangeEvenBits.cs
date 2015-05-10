using System;
using System.Linq;

class ChangeEvenBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] matrix = new int[n];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = int.Parse(Console.ReadLine());
        }
        ulong l= ulong.Parse(Console.ReadLine());
        int numOfChecks = 0;
        if (n>0)
        {
            int inputMax = matrix.Max();
            do
            {
                inputMax >>= 1;
                numOfChecks++;
            }
            while (inputMax > 0);
        }
        int changedDigits = 0;
        for (int i = 0; i < 2 * numOfChecks; i += 2)
        {
            if (((l>>i) &1)==0)
            {
                changedDigits++;
                l |= (1ul << i);
            }
        }
        Console.WriteLine(l);
        Console.WriteLine(changedDigits);
    }
}
