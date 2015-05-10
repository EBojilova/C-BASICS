using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] all= new string[n];
            for (int i = 0; i < n; i++)
            {
                all[i] = Console.ReadLine();
            }
            int count = 1;
            int bestCount = 1;
            string bestString = "";
            for (int i = 1; i < n; i++)
            {
                if (all[i] == all[i - 1])
                    {
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestString = all[i];
                        }
                    }
                else
                {
                    count = 1;
                    bestString = all[i-1];
                }
            }
            Console.WriteLine(bestCount);
            for (int i = 1; i <= bestCount; i++)
            {
                Console.WriteLine(bestString);
            }
        }
    }
}
