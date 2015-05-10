using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankPrice = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            double monthsResult = Math.Ceiling(tankPrice / ((30 - partyDays) * 2 - partyDays * 5.0));
            double years = Math.Floor(monthsResult / 12);
            double months = monthsResult - years * 12;
            Console.WriteLine("{} years, {} months", years, months);
            Console.ReadLine();
        }
    }
}
