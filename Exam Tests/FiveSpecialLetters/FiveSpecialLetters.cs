using System;
using System.Linq;

class FiveSpecialLetters
{
    //Checking all possible combinations in alphabetical order
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        char[] letters = { 'a', 'b', 'c', 'd', 'e' };
        int count = 0;
        for (int p1 = 0; p1 < letters.Length; p1++)
        {
            for (int p2 = 0; p2 < letters.Length; p2++)
            {
                for (int p3 = 0; p3 < letters.Length; p3++)
                {
                    for (int p4 = 0; p4 < letters.Length; p4++)
                    {
                        for (int p5 = 0; p5 < letters.Length; p5++)
                        {
                            string allLetters = "" + letters[p1] + letters[p2] + letters[p3] + letters[p4] + letters[p5];
                            string someLetters = new string(allLetters.ToCharArray().Distinct().ToArray());
                            int weight = 0;
                            //weight('a') = 5; weight('b') = -12;  weight('c') = 47;  weight('d') = 7;  weight('e') = -32
                            for (int i = 1; i <= someLetters.Length; i++)
                            {
                                if (someLetters[i - 1] == 'a')
                                {
                                    weight += 5 * i;
                                }
                                else if (someLetters[i - 1] == 'b')
                                {
                                    weight += -12 * i;
                                }
                                else if (someLetters[i - 1] == 'c')
                                {
                                    weight += 47 * i;
                                }
                                else if (someLetters[i - 1] == 'd')
                                {
                                    weight += 7 * i;
                                }
                                else if (someLetters[i - 1] == 'e')
                                {
                                    weight += -32 * i;
                                }
                            }
                            if (start <= weight && weight <= end)
                            {
                                Console.Write("{0} ", allLetters);
                                count++;
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}

