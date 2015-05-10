using System;

class MoonWeight
{
    static void Main()
    {
        Random r = new Random();
        double EarthWeight = r.Next(40, 150);
        double MoonWeight = 0;
        MoonWeight = EarthWeight * 0.17;
        Console.WriteLine("The weight of a men on the Earth is: {0} kg." + " His weight on the Moon is {1} kg",EarthWeight, MoonWeight);
    }
}
