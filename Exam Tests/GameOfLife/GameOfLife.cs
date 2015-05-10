using System;
using System.Linq;

class GameOfLive
{
    static void Main(string[] args)
    {
        int[] matrix = new int[10];
        int[] finalMatrix = new int[10];
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            matrix[row] |= 1 << col;
        }
        //for (int row = 0; row < 10; row++)
        //{
        //    Console.WriteLine(Convert.ToString(matrix[row], 2).PadLeft(10, '0'));
        //}
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                int countNeibours = 0;
                countNeibours += CheckLifes(matrix, row, col, -1, 0);
                countNeibours += CheckLifes(matrix, row, col, 1, 0);
                countNeibours += CheckLifes(matrix, row, col, 0, -1);
                countNeibours += CheckLifes(matrix, row, col, 0, 1);
                countNeibours += CheckLifes(matrix, row, col, -1, -1);
                countNeibours += CheckLifes(matrix, row, col, -1, 1);
                countNeibours += CheckLifes(matrix, row, col, 1, -1);
                countNeibours += CheckLifes(matrix, row, col, 1, 1);
                //if (countNeibours < 2 && ((matrix[row] >> col & 1) == 1))
                //{
                //    finalMatrix[row] &= ~(1 << col);
                //}
                //if (countNeibours > 3 && ((matrix[row] >> col & 1) == 1))
                //{
                //    finalMatrix[row] &= ~(1 << col);
                //}
                if ((countNeibours == 3 || countNeibours == 2) && ((matrix[row] >> col & 1) == 1))
                {
                    finalMatrix[row] |= 1 << col;
                }
                else if (countNeibours == 3 && ((matrix[row] >> col & 1) == 0))
                {
                    finalMatrix[row] |= 1 << col;
                }
            }
        }
        for (int row = 0; row < 10; row++)
        {
            Console.WriteLine(Convert.ToString(finalMatrix[row], 2).PadLeft(10, '0'));
        }
    }

    private static int CheckLifes(int[] matrix, int row, int col, int rowChange, int colChange)
    {
        int count = 0;
        row += rowChange;
        col += colChange;
        if (row >= 0 && row < 10 && col >= 0 && col < 10 && ((matrix[row] >> col) & 1) == 1)
        {
            count = 1;
        }
        return count;
    }
}


