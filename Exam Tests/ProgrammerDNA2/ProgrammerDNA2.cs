using System;

class ProgrammerDNA
{
    static void Main()
    {
        int totalLength = int.Parse(Console.ReadLine());
        char printChar = char.Parse(Console.ReadLine());

        char spaceChar = '.';

        int size7 = 7;
        int mid7 = size7 / 2;
        int change = 0;
        int dimond = 0;

        for (int counter = 0; counter < totalLength; counter++)
        {
            // Print Block
            for (int i = 0; i < size7; i++)
            {
                if (i >= mid7 - change && i <= mid7 + change)
                {
                    Console.Write(printChar);

                    // Change Letter
                    if (printChar == 'G')
                    {
                        printChar = 'A';
                    }
                    else
                    {
                        printChar++;
                    }
                }
                else
                {
                    Console.Write(spaceChar);
                }
            }

            if (dimond >= mid7)
            {
                change--;
            }
            else
            {
                change++;
            }

            dimond++;

            if (dimond == size7)
            {
                dimond = 0;
                change++;
            }

            Console.WriteLine();
        }
    }
}
