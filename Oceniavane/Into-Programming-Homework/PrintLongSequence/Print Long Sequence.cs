using System;
namespace _16.Print_Long_Sequence
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i < 1000; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(-i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
