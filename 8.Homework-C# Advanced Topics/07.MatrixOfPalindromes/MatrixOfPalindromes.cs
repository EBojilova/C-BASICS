using System;

class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int height = int.Parse(input[0]);
        int width = int.Parse(input[1]);
        string[,] matrix = new string[height, width];
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = string.Format("{0}{1}{0}", (char)('a' + row), (char)('a' + row + col));
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

