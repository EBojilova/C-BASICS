using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            int tankPrice = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());
            int savedMoneyMonth = (30 - partyDays) * 2 - partyDays * 5;
            if (savedMoneyMonth <= 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                double monthsResult = Math.Ceiling(tankPrice * 1.0 / savedMoneyMonth);
                double years = Math.Floor(monthsResult / 12);
                double months = monthsResult - years * 12;
                Console.WriteLine("{0} years, {1} months", years, months);
            }
        }
    }
}
