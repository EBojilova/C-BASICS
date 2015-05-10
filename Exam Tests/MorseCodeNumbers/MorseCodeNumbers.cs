using System;

class MorseCodeNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int nSum = 0;
        while (n > 0)
        {
            nSum += n % 10;
            n /= 10;
        }
        bool isNotMatched = true;
        string[] morseCodes = { "-----", ".----", "..---", "...--", "....-", "....." };
        for (int d1 = 1; d1 <= 5; d1++)
        {
            for (int d2 = 1; d2 <= 5; d2++)
            {
                for (int d3 = 1; d3 <= 5; d3++)
                {
                    for (int d4 = 1; d4 <= 5; d4++)
                    {
                        for (int d5 = 1; d5 <= 5; d5++)
                        {
                            for (int d6 = 1; d6 <= 5; d6++)
                            {
                                if ((d1 * d2 * d3 * d4 * d5 * d6) == nSum)
                                {
                                    isNotMatched = false;
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", morseCodes[d1],morseCodes[d2],morseCodes[d3],morseCodes[d4],morseCodes[d5],morseCodes[d6]);
                                }
                            }
                        }
                    }
                }
            }
        }
        if (isNotMatched)
        {
            Console.WriteLine("No");
        }
    }
}
