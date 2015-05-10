using System;
using System.Globalization;

namespace Problem10BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.Title = "Beer tiMe";
            CultureInfo currentCulture = CultureInfo.InvariantCulture;
            DateTime startBeerTime = DateTime.ParseExact("01:00 PM", "hh:mm tt", currentCulture);
            DateTime endBeerTime = DateTime.ParseExact("03:00 AM", "hh:mm tt", currentCulture);
            Console.Write("Enter beer time in format \"hh:mm tt\":");
            string str = Console.ReadLine();
            DateTime beerTime = DateTime.ParseExact(str, "hh:mm tt", currentCulture);
            if(beerTime.TimeOfDay>=startBeerTime.TimeOfDay || beerTime.TimeOfDay<endBeerTime.TimeOfDay)
            {
                Console.WriteLine("Beer Time!");
            }
            else
            {
                Console.WriteLine("Non-beer time!");

            }
        }
    }
}
