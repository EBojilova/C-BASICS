using System;

class TheExplorer
{
    static void Main(string[] args)
    {
        //Console.WriteLine("n (odd number 3 to 59):");
        ushort n = ushort.Parse(Console.ReadLine());
        string topBottomEmpty = new string('-', n / 2);
        string topBottomLine=string.Format("{0}{1}{0}", topBottomEmpty, '*');
        Console.WriteLine(topBottomLine);
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                string emptySpaceSides = new string('-', (n - i) / 2);
                string emptySpaceMiddle = new string('-', i-2);
                string TopPart = string.Format("{0}{1}{2}{1}{0}", emptySpaceSides, '*', emptySpaceMiddle);
                Console.WriteLine(TopPart);
            }
        }
        for (int i = n-2; i >= 2; i--)
        {
            if (i % 2 == 1)
            {
                string emptySpaceSides = new string('-', (n - i) / 2);
                string emptySpaceMiddle = new string('-', i - 2);
                string TopPart = string.Format("{0}{1}{2}{1}{0}", emptySpaceSides, '*', emptySpaceMiddle);
                Console.WriteLine(TopPart);
            }
        }
        Console.WriteLine(topBottomLine);
    }
}

