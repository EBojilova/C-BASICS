using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bonus score");
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3)
            {
                Console.WriteLine("Result: "+ score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine("Result: " + score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine("Result: " + score * 1000);
            }
            else if(score < 1 || score > 9)
            {
                Console.WriteLine("Invalid score!");
            }
        }
    }
}
