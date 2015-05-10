using System;

class MagicStrings
{
    //Checking all possible combinations in alphabetical order
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };

        int resultsCount = 0;
        for (int p1 = 0; p1 < letters.Length; p1++)
        {
            for (int p2 = 0; p2 < letters.Length; p2++)
            {
                for (int p3 = 0; p3 < letters.Length; p3++)
                {
                    for (int p4 = 0; p4 < letters.Length; p4++)
                    {
                        string left = "" + letters[p1] + letters[p2] + letters[p3] + letters[p4];
                        int weightLeft = 0;
                        foreach (var letterL in left)
                        {
                            if (letterL == 's')
                            {
                                weightLeft += 3;
                            }
                            else if (letterL == 'n')
                            {
                                weightLeft += 4;
                            }
                            else if (letterL == 'k')
                            {
                                weightLeft += 1;
                            }
                            else if (letterL == 'p')
                            {
                                weightLeft += 5;
                            }
                        }
                        for (int p5 = 0; p5 < letters.Length; p5++)
                        {
                            for (int p6 = 0; p6 < letters.Length; p6++)
                            {
                                for (int p7 = 0; p7 < letters.Length; p7++)
                                {
                                    for (int p8 = 0; p8 < letters.Length; p8++)
                                    {
                                        string right = "" + letters[p5] + letters[p6] + letters[p7] + letters[p8];
                                        int weightRight = 0;
                                        foreach (var letterR in right)
                                        {
                                            if (letterR == 's')
                                            {
                                                weightRight += 3;
                                            }
                                            else if (letterR== 'n')
                                            {
                                                weightRight += 4;
                                            }
                                            else if (letterR == 'k')
                                            {
                                                weightRight += 1;
                                            }
                                            else if (letterR == 'p')
                                            {
                                                weightRight += 5;
                                            }
                                        }
                                        if (Math.Abs(weightLeft - weightRight) == diff)
                                        {
                                            Console.WriteLine(left + right);
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

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}

