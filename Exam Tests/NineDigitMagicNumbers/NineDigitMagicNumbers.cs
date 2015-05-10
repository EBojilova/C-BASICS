using System;

class NineDigitMagicNumbers
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int resultsCount = 0;
        for (int d1 = 1; d1 < 8; d1++)
        {
            for (int d2 = 1; d2 < 8; d2++)
            {
                for (int d3 = 1; d3 < 8; d3++)
                {
                    int subSum1 = Num3digits(d1, d2, d3);
                    for (int d4 = 1; d4 < 8; d4++)
                    {
                        for (int d5 = 1; d5 < 8; d5++)
                        {
                            for (int d6 = 1; d6 < 8; d6++)
                            {
                                int subSum2 = Num3digits(d4, d5, d6);
                                if (subSum1 <= subSum2 && subSum2 - subSum1 == diff)
                                {

                                    for (int d7 = 1; d7 < 8; d7++)
                                    {
                                        for (int d8 = 1; d8 < 8; d8++)
                                        {
                                            for (int d9 = 1; d9 < 8; d9++)
                                            {
                                                int subSum3 = Num3digits(d7, d8, d9);
                                                if (subSum2 <= subSum3 && subSum3 - subSum2 == diff && d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 == sum)
                                                {
                                                    Console.WriteLine("{0}{1}{2}", subSum1, subSum2, subSum3);
                                                    resultsCount++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int Num3digits(int d1, int d2, int d3)
    {
        int subSum = d1 * 100 + d2 * 10 + d3;
        return subSum;
    }
}
