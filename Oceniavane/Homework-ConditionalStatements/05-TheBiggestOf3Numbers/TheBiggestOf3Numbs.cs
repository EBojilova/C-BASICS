using System;

    class TheBiggestOf3Numbs
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (a < b && b > c)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
        }
    }

