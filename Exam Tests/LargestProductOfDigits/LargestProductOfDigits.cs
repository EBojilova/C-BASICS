using System;

class LargestProductOfDigits
{
    static void Main(string[] args)
    {
        char[] digtis = Console.ReadLine().ToCharArray();
        int maxProduct6 = int.MinValue;
        for (int i = 0; i < digtis.Length - 5; i ++)
        {
            int product6 = 1;
            for (int j = 0; j < 6; j++)
            {
                product6 *= (digtis[i + j]-'0');
            }
            if (product6 > maxProduct6)
            {
                maxProduct6 = product6;
            }
        }
        Console.WriteLine(maxProduct6);
    }
}
