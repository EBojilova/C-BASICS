using System;

class Volleyball
{
    static void Main()
    {
        //Console.WriteLine("Is it a leap year this year? ");
        string leap = Console.ReadLine();
        //Console.WriteLine("Write how many holidays there are this year :");
        int holidays = int.Parse(Console.ReadLine());
        //Console.WriteLine("How many weekends did Vladi go to his hometown?");
        int weekendsHome = int.Parse(Console.ReadLine());
        double holidaysPlay = holidays * 2.0 / 3.0;
        int normalWeekends = 48 - weekendsHome;
        double weekendsNotWorking = (normalWeekends * 3.0 / 4.0);
        double timePlaying = weekendsNotWorking + holidaysPlay + weekendsHome;
        if (leap == "leap")
            timePlaying = timePlaying * 1.15;

        Console.WriteLine((int)timePlaying);
    }
}