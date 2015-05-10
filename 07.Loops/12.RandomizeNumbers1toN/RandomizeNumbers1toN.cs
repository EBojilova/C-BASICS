using System;
using System.Collections.Generic;

class RandomizeNumbers1toN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            Random r = new Random();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            for (int i = 1; i <= n; i++)
            {
                int index = r.Next(0, numbers.Count);
                Console.Write(numbers[index] + " ");
                numbers.RemoveAt(index);
            }
            Console.WriteLine();
        }
    }

