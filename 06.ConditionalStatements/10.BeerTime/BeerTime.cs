using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter time in format “hh:mm tt”: ");
        DateTime inputDT = DateTime.Parse(Console.ReadLine());
        DateTime startBeerTime = DateTime.Parse("1:00 PM");
        DateTime endBeerTime = DateTime.Parse("3:00 AM");


        if (inputDT >= startBeerTime || inputDT < endBeerTime)
        {
            Console.WriteLine("beer time");
        }
        else if (inputDT < startBeerTime || inputDT >= endBeerTime)
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("invalid time");
        }
        // AM and PM are separate limited intervals and this is the reason for using || with if statement
    }
}
/* Console.Write("Enter a time to check: ");
        try
        {
            DateTime time = DateTime.Parse(Console.ReadLine());

            if (time.Hour >= 13 || time.Hour < 3)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("invalid time");
        }*/
