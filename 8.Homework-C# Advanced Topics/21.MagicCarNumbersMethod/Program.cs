using System;
using System.Collections.Generic;

class MagicCarNumbers
{
    static int GetCharWeight(char c)
    {
        if (c >= '0' && c <= '9')
        {
            return (int)(c - '0');
        }
        switch (c)
        {
            case 'A': return 10;
            case 'B': return 20;
            case 'C': return 30;
            case 'E': return 50;
            case 'H': return 80;
            case 'K': return 110;
            case 'M': return 130;
            case 'P': return 160;
            case 'T': return 200;
            case 'X': return 240;
        }
        return 0;
    }

    static int GetStrWeight(string str)
    {
        int result = 0;
        foreach (char c in str)
        {
            result += GetCharWeight(c);
        }
        return result;
    }

    static void Main(string[] args)
    {
        int weight = int.Parse(Console.ReadLine()),
            foundNumbers = 0;

        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

        foreach (char X in letters)
        {
            foreach (char Y in letters)
            {
                for (int a = 0; a < 10; ++a)
                {
                    if (GetStrWeight("CA" + a + a + a + a + X + Y) == weight)
                    {
                        ++foundNumbers;
                    }

                    for (int b = 0; b < 10; ++b)
                    {
                        if (b != a)
                        {
                            if (GetStrWeight("CA" + a + b + b + b + X + Y) == weight)
                            {
                                ++foundNumbers;
                            }
                            if (GetStrWeight("CA" + a + a + a + b + X + Y) == weight)
                            {
                                ++foundNumbers;
                            }
                            if (GetStrWeight("CA" + a + a + b + b + X + Y) == weight)
                            {
                                ++foundNumbers;
                            }
                            if (GetStrWeight("CA" + a + b + a + b + X + Y) == weight)
                            {
                                ++foundNumbers;
                            }
                            if (GetStrWeight("CA" + a + b + b + a + X + Y) == weight)
                            {
                                ++foundNumbers;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(foundNumbers);
    }
}