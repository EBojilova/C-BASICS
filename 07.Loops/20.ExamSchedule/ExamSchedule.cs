using System;
using System.Globalization;

class ExamSchedule
{
    static void Main()
    {
        //Console.Write("Starting hour [1…12]: ");
        string startHours = (Console.ReadLine());
        //Console.Write("Starting minite [0…59]: ");
        string startMin = (Console.ReadLine());
        //Console.Write("Part of the day: AM or PM: ");
        string startPartDay = (Console.ReadLine());
        //string start = "9:30 PM";
        string start = string.Format("{0}:{1} {2}", startHours, startMin, startPartDay);
        DateTime startTime = DateTime.Parse(start);
        //Console.Write("Duration hours[0…23]: ");
        int durHours = int.Parse(Console.ReadLine());
        //Console.Write("Duration minutes[0…59]: ");
        int durMin = int.Parse(Console.ReadLine());
        DateTime finishTime = startTime.AddHours(durHours).AddMinutes(durMin);
        Console.WriteLine(finishTime.ToString("hh:mm:tt", CultureInfo.InvariantCulture));
        // Displays 06:09:PM
    }
}

