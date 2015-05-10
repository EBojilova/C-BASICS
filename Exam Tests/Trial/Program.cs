using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersSymbolsNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sumLetters = 0;
        int sumNumbers = 0;
        int sumSymbols = 0;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().Trim().ToLower();
            for (int j = 0; j < input.Length; j++)
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
