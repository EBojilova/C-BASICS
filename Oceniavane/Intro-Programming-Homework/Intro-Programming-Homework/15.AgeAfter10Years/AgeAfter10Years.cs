using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My birthday year is 1988");
            int born = 1988;
            int yearNow = 2015;
            int years = yearNow - born;
            Console.WriteLine("How old am I now?:");
            Console.WriteLine(yearNow - born);
            Console.WriteLine("How old will I be after 10 years?:");
            Console.WriteLine(years + 10);
        }
    }
}
