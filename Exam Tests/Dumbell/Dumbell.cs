using System;

class Dumbell
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
        int counter = 0;
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', n / 2-1-counter), new string('*', n / 2 + counter), new string(i==(n-2)/2? '=':'.', n));
            if (i < (n-2) / 2)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
    }
}
