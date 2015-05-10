using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomizeTheNumbers
{
    static void Main()
    {
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            Random randomGenerator = new Random();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            for (int i = 1; i <= n; i++)
            {
                int index = randomGenerator.Next(0, numbers.Count);
                Console.Write("{0} ", numbers[index]);
                numbers.RemoveAt(index);
            }
            Console.WriteLine();
        }
    }

}