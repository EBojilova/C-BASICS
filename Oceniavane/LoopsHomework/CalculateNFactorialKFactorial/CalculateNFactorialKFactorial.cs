using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CalculateNFactorialKFactorial
    {
        static void Main()
        {
            Console.WriteLine("Please enter \"n\" and \"k\":");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nFac = 1;
            int kFac = 1;
            if (n < 100 && n >= k && n > 1 && k > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    nFac *= i;
                    if (i <= k)
                    {
                        kFac *= i;
                    }

                }
                Console.WriteLine(nFac / kFac);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

       } 
    }

