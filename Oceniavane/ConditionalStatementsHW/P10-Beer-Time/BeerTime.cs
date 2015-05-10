using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace P10_Beer_Time
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            CultureInfo enUS = new CultureInfo("en-US");

            DateTime time;
            DateTime startTime = DateTime.Parse("01:00 PM");
            DateTime endTime = DateTime.Parse("03:00 AM");

            bool convert = false;
            Console.Write("Enter time (in format h:mm tt): ");
            convert = DateTime.TryParseExact(Console.ReadLine(), "h:mm tt", enUS, DateTimeStyles.None, out time);
            if (convert)
            {
                if (time >= startTime || time < endTime)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
