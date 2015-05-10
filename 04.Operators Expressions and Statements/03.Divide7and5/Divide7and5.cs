using System;

    class Divide7and5
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            int n= Convert.ToInt32(Console.ReadLine());
            bool devide7and5 = (n % 5 == 0 && n % 7 == 0 && n !=0);
            Console.WriteLine(devide7and5);
        }
    }

