using System;

class DifferenceBetweenDates
{
    static void Main(string[] args)
    {
        string firstDateStr = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstDateStr, "d.MM.yyyy", null);
        string secondDateStr = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(secondDateStr, "d.MM.yyyy", null);
        TimeSpan difference = secondDate - firstDate;
        Console.WriteLine(difference.TotalDays);
    }
}

