using System;
using System.Collections.Generic;
using System.Linq;

class OddEvenElements
{
    static void Main(string[] args)
    {
        string inputLine;
        if (!(string.IsNullOrEmpty(inputLine = Console.ReadLine())))
        {
            decimal[] numbers = Array.ConvertAll(inputLine.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries), s => decimal.Parse(s));
            var oddNum = numbers.Where((c, i) => i % 2 == 0).ToArray();
            var evenNum = numbers.Where((c, i) => i % 2 != 0).ToArray();
            if (evenNum.Length > 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddNum.Sum(), (double)oddNum.Min(), (double)oddNum.Max(), (double)evenNum.Sum(), (double)evenNum.Min(), (double)evenNum.Max());
            }
            else
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={3}, EvenMax={3}", (double)oddNum.Sum(), (double)oddNum.Min(), (double)oddNum.Max(), "No");
            }
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={0}, EvenMin={0}, EvenMax={0}", "No");
        }
    }
}
