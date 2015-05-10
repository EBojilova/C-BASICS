using System;

class Arrow
{
    static void Main()
    {
        //Console.Write("Enter an integer number \"n\" (odd number)between 3 and 79 inclusive:");
        ushort n = ushort.Parse(Console.ReadLine());
        string top = new string('#', n);
        string emptySideTop = new string('.', n / 2);
        string emptyInsideTop = new string('.', n -2);
        string topLine = string.Format("{0}{1}{0}", emptySideTop, top);
        string topArrow = string.Format("{0}#{1}#{0}", emptySideTop, emptyInsideTop);
        Console.WriteLine(topLine);
        for (int i = 1; i <= n-2; i++)
        {
            Console.WriteLine(topArrow);
        }
        string middle = new string('#', n/2+1);
        string middleArrow = string.Format("{0}{1}{0}", middle, emptyInsideTop);
        Console.WriteLine(middleArrow);
        for (int i = 1, j=0; i <= n - 2; i++)
        {
            string emptySideBtm = new string('.', i);
            string emtyInsideBtm=new string('.', 2*n -5-j);
            string bottomArrow = string.Format("{0}#{1}#{0}", emptySideBtm, emtyInsideBtm);
            Console.WriteLine(bottomArrow);
            j += 2;
        }
        Console.WriteLine("{0}#{0}", new string('.', n-1));
    }
}

