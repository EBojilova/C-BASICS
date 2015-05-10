using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FruitMarket
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>()
        {
            {"banana", 1.8M},
            {"cucumber", 2.75M},
            {"tomato", 3.20M},
            {"orange", 1.60M},
            {"apple", 0.860M}
        };
        decimal sum = 0;
        string dayOfWeek = Console.ReadLine();

        /*•	Friday  10% off for all products
        •	Sunday  5% off for all products
        •	Tuesday  20% off for fruits
        •	Wednesday  10% off for vegetables
        •	Thursday  30% off for bananas*/
        if (dayOfWeek == "Friday")
        {
            foreach (string key in productPrice.Keys.ToList())
            {
                productPrice[key] *= 0.9M;
            }
        }
        if (dayOfWeek == "Sunday")
        {
            foreach (string key in productPrice.Keys.ToList())
            {
                productPrice[key] *= 0.95M;
            }
        }
        if (dayOfWeek == "Tuesday")
        {
            productPrice["banana"] *= 0.8M;
            productPrice["orange"] *= 0.8M;
            productPrice["apple"] *= 0.8M;
        }
        if (dayOfWeek == "Wednesday")
        {
            productPrice["cucumber"] *= 0.9M;
            productPrice["tomato"] *= 0.9M;
        }
        if (dayOfWeek == "Thursday")
        {
             productPrice["banana"] *= 0.7M;
        }


        for (int i = 0; i < 3; i++)
        {
            decimal quantity = decimal.Parse(Console.ReadLine());
            string product = Console.ReadLine();
            sum += quantity * productPrice[product];
        }
        Console.WriteLine("{0:F2}",sum);
    }
}
