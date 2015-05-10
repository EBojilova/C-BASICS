using System;
using System.Collections.Generic;
using System.Linq;

class AverageLoadTimeCalc
{
    static void Main()
    {
        string inputLine;
        //Keeps the sum of the Load times for each site.
        Dictionary<string, double> sites = new Dictionary<string, double>();
        //Keeps How many times we have sum the Load time for each site.
        Dictionary<string, int> counters = new Dictionary<string, int>();

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            string[] input = inputLine.Split(' ');
            //From the input we take only web URL and loat time. We do not need Date Time.
            string webURL = input[2];
            double loadTime = double.Parse(input[3]);
            if (!sites.Keys.Contains(webURL))
            {
                sites.Add(webURL, loadTime);
                counters.Add(webURL, 1);
            }
            else
            {
                sites[webURL] +=loadTime;
                counters[webURL]++;
            }
        }
        // Output
        foreach (string link in sites.Keys)
        {
            Console.WriteLine("{0} -> {1}", link, sites[link] / counters[link]);
        }
    }
}
