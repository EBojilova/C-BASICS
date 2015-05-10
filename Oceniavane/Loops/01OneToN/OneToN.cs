using System;


    class OneToN
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number:");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter <= number)
            {
                Console.WriteLine("{0}", counter);
                counter++;
            }
          
        }
    }
