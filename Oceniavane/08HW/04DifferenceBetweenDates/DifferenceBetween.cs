using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DifferenceBetweenDates
{
    class DifferenceBetween
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Days between : {0}", CountOfDays(firstDate, secondDate));
        }
        static double CountOfDays(DateTime startDate, DateTime endDate)
        {
            TimeSpan daysBetweenDates = endDate - startDate;
            double result = daysBetweenDates.TotalDays;
            return result;
        }
    }
}
