using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MinMaxSumAndAverage
    {
        static void Main()
        {
            Console.WriteLine("Please enter your numbers:");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());        
            }
            Array.Sort(numbers);
            {
                Console.WriteLine("Min = " + numbers.Min());
                Console.WriteLine("Max = " + numbers.Max());
                Console.WriteLine("Sum = " + numbers.Sum());
                Console.WriteLine("Avg = {0:0.00}", + numbers.Average());
            }
        }
    }

