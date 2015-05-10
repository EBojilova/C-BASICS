using System;

class ProgrammerDNA
{
    static void Main(string[] args)
    {
        short length = short.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        sbyte dotsCount = 3, step = 1;
        for (int i = 0; i < length; ++i)
        {
            Console.Write(new string('.', dotsCount));
            for (int j = 0; j < 7 - 2 * dotsCount; ++j)
            {
                Console.Write(letter);
                ++letter;
                if (letter > 'G')
                {
                    letter = 'A';
                }
            }
            Console.WriteLine(new string('.', dotsCount));
            if (dotsCount < 1)
            {
                step *= -1;
            }
            else if (dotsCount > 2)
            {
                if (i % 7 == 6)
                {
                    dotsCount = 2;// za da se izchertae izcialo diamanta i da pochne otnachalo se zastoporiava za edin cikal
                }
                else
                {
                    step *= -1;
                }
            }
            dotsCount += step;
        }
    }
}