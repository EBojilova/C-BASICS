using System;
using System.Collections.Generic;
using System.Linq;

class BiggestTriple
{
    static void Main()
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        int maxSum = Int32.MinValue; // setting to initial Int32.MinValue is important,
        int sum = 0;
        List<int> temp = new List<int>();
        List<int> final = new List<int>();
        for (int i = 0; i < numbers.Length; i += 3)
        {
            temp = numbers.Skip(i).Take(3).ToList();
            sum = temp.Sum();

            if (sum > maxSum)
            {
                maxSum = sum;
                final = temp;
            }
        }
        Console.WriteLine(string.Join(" ", final));
    }
}