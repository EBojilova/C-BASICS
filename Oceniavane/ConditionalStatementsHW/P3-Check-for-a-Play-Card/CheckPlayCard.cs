using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Check_for_a_Play_Card
{
    class CheckPlayCard
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool validCard = false, convert = false;
            int inputInt;

            convert = int.TryParse(input, out inputInt);
            if (convert)
            {
                if (inputInt >= 2 && inputInt <= 10)
                {
                    validCard = true;
                }
            }
            else
            {
                switch (input)
                {
                    case "J":
                    case "K":
                    case "Q":
                    case "A":
                        validCard = true; break;
                }
            }
            if (validCard)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}
