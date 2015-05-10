using System;

class MatrixOfPalindromes
{
    static void Main(string[] args)
    {
        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write("" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row) + " ");
            }
            Console.WriteLine();
        }
    }
}