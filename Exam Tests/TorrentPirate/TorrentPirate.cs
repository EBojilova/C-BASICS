using System;

class TorrentPirate
{
    static void Main(string[] args)
    {
        int downloadData = int.Parse(Console.ReadLine());
        int cinemaPrice=int.Parse(Console.ReadLine());
        int wifeSpending = int.Parse(Console.ReadLine());
        double mallCost = (downloadData / (2.0 * 3600)) * wifeSpending;
        double cinemaCost = (downloadData / 1500.00) * cinemaPrice;
        if (mallCost<=cinemaCost)
        {
            Console.WriteLine("mall -> {0:F2}lv", mallCost);
        }
        else
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaCost);
        }
    }
}
