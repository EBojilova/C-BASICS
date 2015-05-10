using System;

class PrintDeck52cards
{
    static void Main()
    {
        string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
        char[] symbol = { (char)5, (char)4, (char)3, (char)6 };
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < symbol.Length; j++)
            {
                Console.Write("{0,2}{1} ", num[i], symbol[j]);
            }
            Console.WriteLine();
        }
    }
}

