using System;

class ProgrammerDNA
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        char[] lettersAll = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        int LetterIndex = Array.IndexOf(lettersAll, letter);
        int nCheck = n / 7;
        int lineCheck = 0;
        for (int j = 0; j <= nCheck; j++)
        {
            int counter = 0;
            for (int i = 0; i < 7; i++)
            {
                if (lineCheck >= n)
                {
                    break;
                }
                Console.Write("{0}", new string('.', 3 - counter));
                for (int k = 0; k < 1 + 2 * counter; k++)
                {
                    Console.Write(lettersAll[(LetterIndex) % 7]);
                    LetterIndex++;
                }
                Console.WriteLine("{0}", new string('.', 3 - counter));
                if (i < 3)
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                lineCheck++;
            }
        }
    }
}
