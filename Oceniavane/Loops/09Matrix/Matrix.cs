using System;
class Matrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = n;
        int j = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            for (j = i + 1; j <= counter; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            counter++;

        }
    }
}