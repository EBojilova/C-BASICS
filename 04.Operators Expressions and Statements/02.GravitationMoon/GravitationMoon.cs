using System;

class GravitationMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the weight of the man:");
        double weightEarth = Convert.ToDouble(Console.ReadLine());
        double weightMoon = 0.17 * weightEarth;
        Console.WriteLine(weightMoon);
    }
}

