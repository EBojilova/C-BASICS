using System;
using System.Collections.Generic;
using System.Linq;

class CurrencyCheck
{
    static void Main(string[] args)
    {
        //with decial[] the momory is 0.013
        Dictionary<string, decimal> currency = new Dictionary<string, decimal>()
        {
            {"rubles", 0.035M},
            {"dollar", 1.5M},
            {"euro", 1.95M},
            {"levaB", 0.5M},
            {"levaM", 1M}
        };
        currency["rubles"] *= decimal.Parse(Console.ReadLine());
        currency["dollar"] *= decimal.Parse(Console.ReadLine());
        currency["euro"] *= decimal.Parse(Console.ReadLine());
        currency["levaB"] *= decimal.Parse(Console.ReadLine());
        currency["levaM"] *= decimal.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}",currency.Min(x => x.Value));
    }
}
