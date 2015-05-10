using System;
using System.Collections.Generic;
using System.Linq;

class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

        string allNum = Console.ReadLine();
        string[] numStr = allNum.Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries);
        decimal nI = new int();
        decimal sumOdd= 0;
        decimal sumEven = 0;
        decimal minOdd= decimal.MaxValue;
        decimal minEven = decimal.MaxValue;
        decimal maxOdd = decimal.MinValue;
        decimal maxEven = decimal.MinValue;
        for (int i = 1; i <= numStr.Length; i++)
        {
            nI = decimal.Parse(numStr[i-1]);
            if (i%2==1)
            {
                sumOdd += nI;
                maxOdd = Math.Max(nI, maxOdd);
                minOdd = Math.Min(nI, minOdd);
            }
            else
            {
                sumEven += nI;
                maxEven = Math.Max(nI, maxEven);
                minEven = Math.Min(nI, minEven);
            }
        }
        if (numStr.Length==1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={3}, EvenMax={3}", (double)sumOdd, (double)minOdd, (double)maxOdd, "No");
        }
        else if (numStr.Length==0)
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={0}, EvenMin={0}, EvenMax={0}",  "No");
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)sumOdd, (double)minOdd, (double)maxOdd, (double)sumEven, (double)minEven, (double)maxEven);
        }
        Console.WriteLine(1.750D);
        Console.WriteLine(1.750M);
    }
}

