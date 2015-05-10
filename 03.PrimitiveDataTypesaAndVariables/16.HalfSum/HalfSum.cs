using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int subSum1 = 0;
        for (int i = 0; i < n; i++)
        {
            int numberSequence = int.Parse(Console.ReadLine());
            subSum1 = subSum1 + numberSequence;
        }
        int subSum2 = 0;
        for (int i = 0; i < n; i++)
        {
            int numberSequence = int.Parse(Console.ReadLine());
            subSum2 = subSum2 + numberSequence;
        }
        if (subSum1 == subSum2)
        {
            Console.WriteLine("Yes, sum={0}", subSum1);
        }
        else
        {
            int diff = Math.Abs(subSum1 - subSum2);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}


