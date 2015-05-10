using System;
namespace _8.Prime_Number_Check
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            if ((num == 2) || (num == 3) || (num == 5) || (num == 7))
            {
                Console.WriteLine(true);

            }
            if ((num % 2 == 0) || (num % 3 == 0) || (num % 5 == 0) || (num % 7 == 0) || (num == 0) || (num == 1))
            {
                Console.WriteLine(false);

            }
            else
            {
                Console.WriteLine(true);

            }
           

        }
    }
}
