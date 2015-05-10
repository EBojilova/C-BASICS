using System;

    class NumberComparer
    {
        static void Main(string[] args)
        {
            double a, b = new double();
           Console.Write("Enter a: ");
           try
           {
               double aCheck = double.Parse(Console.ReadLine());
               a = aCheck;
           }
            catch (FormatException)
           {
               Console.WriteLine("out of range");
               return;
           }
           
            Console.Write("Enter b: ");
            try
            {
                double bCheck = double.Parse(Console.ReadLine());
                b = bCheck;
            }
            catch (FormatException)
            {
                Console.WriteLine("out of range");
                return;
            }
            Console.WriteLine(Math.Max(a,b));
        }
    }

