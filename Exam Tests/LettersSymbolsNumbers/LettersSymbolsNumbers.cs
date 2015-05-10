using System;

class LettersSymbolsNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sumLetters = 0;
        int sumNumbers = 0;
        int sumSymbols = 0;
        for (int j = 0; j < n; j++)
        {
            string input = Console.ReadLine().Trim().ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' || input[i] == '\t' || input[i] == '\n' || input[i] == '\r')
                {
                    continue;
                }
                else if (input[i] >= '0' && input[i] <= '9')
                {
                    sumNumbers += (input[i] - '0') * 20;
                }
                else if (input[i] >= 'a' && input[i] <= 'z')
                {
                    sumLetters += (input[i] - 'a' + 1) * 10;
                }
                else
                {
                    sumSymbols += 200;
                }
            }
        }
        Console.WriteLine(sumLetters);
        Console.WriteLine(sumNumbers);
        Console.WriteLine(sumSymbols);
    }
}
