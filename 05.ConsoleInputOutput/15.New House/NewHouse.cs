using System;

class NewHouse
{
    static void Main()
    {
        //Console.Write("Enter an integer number \"n\" (odd number) = height of sunglasses:");
        ushort n = ushort.Parse(Console.ReadLine());
        string fillHouse = new string('*', n - 2);
        string bodyHouse = string.Format("{0}{1}{0}", '|', fillHouse);
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                string emptySpace = new string('-', (n - i) / 2);
                string roof = new string('*', i);
                string roofPart = string.Format("{0}{1}{0}", emptySpace, roof);
                Console.WriteLine(roofPart);
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(bodyHouse);
        }
    }
}

