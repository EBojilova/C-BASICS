using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                
                Console.WriteLine("Result: {0} {1}", secondNum, firstNum);
            }
            else
            {
                Console.WriteLine("Result: {0} {1}", firstNum, secondNum);
            }
        }
    }

