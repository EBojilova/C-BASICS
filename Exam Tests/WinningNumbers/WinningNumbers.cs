using System;

class WinningNumbers
{
    static void Main()
    {
        char[] letters = (Console.ReadLine()).ToLower().ToCharArray();
        int letSum = 0;
        foreach (var letter in letters)
        {
            letSum += letter - 'a' + 1;
        }

        int resultsCount = 0;
        int left = new int();
        int right = new int();
        for (int d1 = 0; d1 < 10; d1++)
        {
            for (int d2 = 0; d2 < 10; d2++)
            {
                for (int d3 = 0; d3 < 10; d3++)
                {
                    for (int d4 = 0; d4 < 10; d4++)
                    {
                        for (int d5 = 0; d5 < 10; d5++)
                        {
                            for (int d6 = 0; d6 < 10; d6++)
                            {
                                right = d1*d2*d3;
                                left = d4 * d5 * d6;
                                if (right==letSum && left==letSum)
                                {
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}",d1,d2,d3,d4,d5,d6);
                                    resultsCount++;
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
}
