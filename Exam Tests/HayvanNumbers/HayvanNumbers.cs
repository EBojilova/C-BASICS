using System;

class HayvanNumbers
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int resultsCount = 0;
        for (int d1 = 5; d1 < 10; d1++)
        {
            for (int d2 = 5; d2 < 10; d2++)
            {
                for (int d3 = 5; d3 < 10; d3++)
                {
                    int subSum1 = Num3digits(d1, d2, d3);
                    for (int d4 = 5; d4 < 10; d4++)
                    {
                        for (int d5 = 5; d5 < 10; d5++)
                        {
                            for (int d6 = 5; d6 < 10; d6++)
                            {
                                int subSum2 = Num3digits(d4, d5, d6);
                                if (subSum1 <= subSum2 && subSum2 - subSum1 == diff)
                                {

                                    for (int d7 = 5; d7 < 10; d7++)
                                    {
                                        for (int d8 = 5; d8 < 10; d8++)
                                        {
                                            for (int d9 = 5; d9 < 10; d9++)
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
