using System;

class WeirdCombination
{
    static void Main()
    {
        string letters = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        int count = 0;
        bool hasCombination = false;
        for (int p1 = 0; p1 < letters.Length; p1++)
        {
            for (int p2 = 0; p2 < letters.Length; p2++)
            {
                for (int p3 = 0; p3 < letters.Length; p3++)
                {
                    for (int p4 = 0; p4 < letters.Length; p4++)
                    {
                        for (int p5 = 0; p5 < letters.Length && count <= n; p5++, count++)
                        {
                            if (count == n)
                            {
                                string combination = "" + letters[p1] + letters[p2] + letters[p3] + letters[p4] + letters[p5];
                                Console.WriteLine(combination);
                                hasCombination = true;
                            }
                        }
                    }
                }
            }
        }
        if (!hasCombination)
        {
            Console.WriteLine("No");
        }
    }
}

