using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Please enter an positive integer:");
            int number = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Your input is not valid number");
            }
            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ",i);
            }
        }
    }

