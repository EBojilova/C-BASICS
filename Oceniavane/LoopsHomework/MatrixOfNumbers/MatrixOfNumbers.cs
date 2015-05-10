using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int nextNumber = 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (number < 10)
                    {
                        Console.Write("{0}  ", number);
                    }
                    else
                    {
                        Console.Write("{0} ", number);
                    }
                    number++;
                }
                number = nextNumber;
                nextNumber++;
                Console.WriteLine();
            }
        }
    }