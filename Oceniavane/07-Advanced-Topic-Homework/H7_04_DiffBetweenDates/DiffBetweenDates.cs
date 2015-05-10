using System;   
using System.Threading;
using System.Globalization;

class DiffBetweenDates
{
    static void Main(string[] args)
    {
        DateTime startTime = DateTime.Parse(Console.ReadLine());
        DateTime endTime = DateTime.Parse(Console.ReadLine());

        Console.WriteLine((endTime - startTime).TotalDays);
    }
}