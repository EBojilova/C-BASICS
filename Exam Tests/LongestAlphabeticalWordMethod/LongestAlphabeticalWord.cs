using System;

class LongestAlphabeticalWord
{
    static void Main(string[] args)
    {
        string symbol = Console.ReadLine();
        int size = int.Parse(Console.ReadLine());
        char[,] matrix = new char[size, size];
        int n = 0;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = symbol[n % symbol.Length];
                n++;
                //Console.Write("{0} ", matrix[row, col]);
            }
            //Console.WriteLine();
        }
        string longestStr = "";
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                longestStr = LongestWordDirection(matrix, longestStr, row, col,  1, 0);
                longestStr = LongestWordDirection(matrix, longestStr, row, col, -1, 0);
                longestStr = LongestWordDirection(matrix, longestStr, row, col, 0, 1);
                longestStr = LongestWordDirection(matrix, longestStr, row, col, 0, -1);
            }
        }
        Console.WriteLine(longestStr);
    }

    private static string LongestWordDirection(char[,] matrix, string longestStr, int row, int col, int rowDir,  int colDir)
    {
        string strTemp = "" + matrix[row, col];
        char tempChar = matrix[row, col];
        row += rowDir;
        col += colDir;
        while (row >= 0 && row <= matrix.GetLongLength(0) && col >= 0 && col <= matrix.GetLongLength(1))
        {
            if (tempChar < matrix[row, col])
            {
                strTemp += matrix[row, col];
                tempChar = matrix[row, col];
                row += rowDir;
                col += colDir;
            }
            else
            {
                break;
            }
        }
        if ((strTemp.Length > longestStr.Length) || ((strTemp.Length == longestStr.Length && strTemp.CompareTo(longestStr) < 0)))
        {
            longestStr = strTemp;
        }
        return longestStr;
    }
}
