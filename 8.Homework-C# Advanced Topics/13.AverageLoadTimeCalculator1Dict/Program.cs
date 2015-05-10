using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Dictionary<string, List<double>> report = new Dictionary<string, List<double>>();

        string inputLine = Console.ReadLine();
        while (inputLine != string.Empty)
        {
            string[] input = inputLine.Split(' ');

            int index = 2;
            string link = input[index];
            double time = double.Parse(input[index + 1]);

            if (!report.Keys.Contains(link))
            {
                report[link] = new List<double>();
            }
            report[link].Add(time);

            inputLine = Console.ReadLine();
        }

        Console.WriteLine();
        foreach (string site in report.Keys)
        {
            Console.WriteLine("{0} -> {1}", site, report[site].Average());
        }
    }
}