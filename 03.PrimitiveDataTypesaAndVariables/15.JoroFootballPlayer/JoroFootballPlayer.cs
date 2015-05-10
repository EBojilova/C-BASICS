using System;

class JoroFootballPlayer
{
    static void Main()
    {
        //Console.WriteLine("Enter “t” for leap year or “f” for year that is not leap:");
        string typeYear = Console.ReadLine();
        byte typeYear2 = 0;
        if (typeYear == "t")
        {
            typeYear2 = 3;
        }
        else if (typeYear == "f")
        {
            typeYear2 = 0;
        }
        //else
       // {
           // Console.WriteLine("Wrong symbol, please enter again!");
       // }
        //Console.WriteLine("Enter the number of holidays “p” in the year (which are not Saturday or Sunday):");
        ushort p = ushort.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the number of the weekends “h” that Joro spends in his hometown:");
        byte h = byte.Parse(Console.ReadLine());
        int totaPlaysYear = (((52 - h) * 2) / 3 + h + (p / 2)) + typeYear2;
        //Console.WriteLine("Joro plays football {0} times per this year.", totaPlaysYear);
        Console.WriteLine(totaPlaysYear);
    }
}

