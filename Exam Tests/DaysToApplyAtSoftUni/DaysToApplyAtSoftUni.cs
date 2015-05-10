using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysToApplyAtSoftUni
{
    class DaysToApplyAtSoftUni
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            DateTime today = DateTime.Now;
            DateTime deadline = new DateTime(2015, 1, 1).AddDays(82);
            TimeSpan daysLeft = (deadline - today);
            ushort daysLeftByte = (ushort)(daysLeft.TotalDays);
            string daysLeftBinary = Convert.ToString((daysLeftByte), 2);
            Console.WriteLine("{0}, you have only {1} days to apply for the spring semester at Software University!", name, daysLeftBinary );
        }
    }
}
