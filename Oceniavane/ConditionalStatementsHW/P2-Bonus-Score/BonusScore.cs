using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = 0;

            bool convert = false;

            while (!convert)
            {
                Console.Write("Enter score: ");
                convert = (int.TryParse(Console.ReadLine(), out score)) && (score > 0) && (score <= 9);
                if (!convert)
                {
                    Console.Write("Error! ");
                }
            }

            if (score <= 3)
            {
                score *= 10;
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
            }
            else if (score >= 7)
            {
                score *= 1000;
            }
            Console.WriteLine("Score with bonus is: " + score);
        }
    }
}
