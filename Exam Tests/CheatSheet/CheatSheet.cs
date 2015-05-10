using System;

class CheatSheet
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        long startRow = long.Parse(Console.ReadLine());
        long startCol = long.Parse(Console.ReadLine());
        long[,] matrix = new long[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = (startRow + row) * (startCol + col);
                Console.Write("{0} ",matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}
