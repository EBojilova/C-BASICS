using System;

class Boat
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}", new string('.', n -1- 2*counter));
            Console.Write("{0}", new string('*', 1 + 2 * counter));
            Console.WriteLine("{0}", new string('.', n));
            if (i < n / 2)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.Write("{0}", new string('.', i));
            Console.Write("{0}", new string('*',2*n-2*i));
            Console.WriteLine("{0}", new string('.', i));
        }
    }
}
