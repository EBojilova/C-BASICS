using System;

class Sunglasses
{
    static void Main()
    {
        //Console.WriteLine("Enter an integer number \"n\" (odd number) = height of sunglasses:");
        ushort n = ushort.Parse(Console.ReadLine());
        string topBottom = new string('*', 2 * n);
        string emptySpace = new string(' ', n);
        string lens = new string('/', n * 2 - 2);
        string bride = new string('|', n);
        string middleFrame = string.Format("{0}{1}{0}{2}{0}{1}{0}", '*', lens,emptySpace);
        string brideFrame = string.Format("{0}{1}{0}{2}{0}{1}{0}", '*', lens, bride);
        string topBottomFrame = string.Format("{0}{1}{0}", topBottom,emptySpace);
        Console.WriteLine(topBottomFrame);
        for (int i = 0; i < (n-3)/2; i++)
        {
            Console.WriteLine(middleFrame);
        }
        Console.WriteLine(brideFrame);
        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine(middleFrame);
        }
        Console.WriteLine(topBottomFrame);
    }
}

/*   // Input the number:
            int n = int.Parse(Console.ReadLine());

            for (int d = 0; d < n * 2; d++)
            {
                Console.Write("*");

            }
            for (int y = 0; y < n; y++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < n * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int c = 0; c < n - 2; c++)
            {


                if (c != n / 2 - 1)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', ((n * 2) - 2)), new string(' ', n));
                }

                else if (c == n / 2 - 1)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', new string('/', ((n * 2) - 2)), new string('|', n));
                }

            }
            for (int dd = 0; dd < n * 2; dd++)
            {
                Console.Write("*");

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < n * 2; k++)
            {
                Console.Write("*");
            }
*/