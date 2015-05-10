using System;

class PokerStraight
{
    static void Main(string[] args)
    {
        int w = int.Parse(Console.ReadLine());
        string[] face = { null, "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //Cards suits are: Clubs (C), Diamonds (D), Hearts (H) and Spades (S)
        //char[] suit = { '0', (char)5, (char)4, (char)3, (char)6 };
        char[] suit = { '0', 'C', 'D', 'H', 'S' };
        int counter = 0;
        //classical playing cards have face and suit
        for (int f1 = 1; f1 < face.Length - 4; f1++)
        {
            for (int s1 = 1; s1 < suit.Length; s1++)
            {
                for (int f2 = f1 + 1; f2 < face.Length - 3; f2++)
                {
                    for (int s2 = 1; s2 < suit.Length ; s2++)
                    {
                        for (int f3 = f2 + 1; f3 < face.Length - 2; f3++)
                        {
                            for (int s3 = 1; s3 < suit.Length; s3++)
                            {
                                for (int f4 = f3 + 1; f4 < face.Length - 1; f4++)
                                {
                                    for (int s4 = 1; s4 < suit.Length; s4++)
                                    {
                                        for (int f5 = f4 + 1; f5 < face.Length; f5++)
                                        {
                                            for (int s5 = 1; s5 < suit.Length; s5++)
                                            {

                                                if (f2 == f1 + 1 && f3 == f2 + 1 && f4 == f3 + 1 && f5 == f4 + 1)
                                                {
                                                    //•	weight(AC 2H 3H 4C 5S) = (10*1 + 1) + (20*2 + 3) + (30*3 + 3) + (40*4 + 1) + (50*5 + 4) = 562
                                                    int weight = (f1 * 10 + s1) + (f2 * 20 + s2) + (f3 * 30 + s3) + (f4 * 40 + s4) + (f5 * 50 + s5);
                                                    if (w == weight)
                                                    {
                                                        //Console.WriteLine("({0}{1} {2}{3} {4}{5} {6}{7} {8}{9})", face[f1],suit[s1],face[f2],suit[s2],face[f3],suit[s3],face[f4],suit[s4],face[f5],suit[s5]);
                                                        counter++;
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
        }
        Console.WriteLine(counter);
    }
}
