using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NotDivisible
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 7 == 0)
                    continue;
               {
                   if (i % 3 == 0)
                       continue;
                   {
                       Console.Write("{0} ",i);
                   }
               }
            }
        }
    }
