using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

    class PrintADeck
    { 
        static void Main()
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
            string[] sign = { "\u2663", "\u2666", "\u2665", "\u2660" };
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < sign.Length; j++)
                {
                    Console.Write(cards[i].PadLeft(2, ' ') + sign[j].PadRight(1, ' ') + " ");
                }
                Console.WriteLine();
            }
        }
    }

