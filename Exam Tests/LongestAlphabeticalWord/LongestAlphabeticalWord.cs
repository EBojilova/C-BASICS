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
        string longTemp;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                longTemp = "" + matrix[row, col];
                for (int i = col; i < size - 1; i++)
                {
                    if (matrix[row, i] < matrix[row, i + 1])
                    {
                        longTemp += matrix[row, i + 1];
                    }
                    else
                    {
                        break;
                    }
                }
                longestStr = LongestStrAlphabetical(longestStr, longTemp);
            }
            for (int col = size - 1; col >= 0; col--)
            {
                longTemp = "" + matrix[row, col];
                for (int i = col; i > 0; i--)
                {
                    if (matrix[row, i] < matrix[row, i - 1])
                    {
                        longTemp += matrix[row, i - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                longestStr = LongestStrAlphabetical(longestStr, longTemp);
            }

        }
        //----------------------------------------------------
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                longTemp = "" + matrix[row, col];
                for (int i = row; i < size - 1; i++)
                {
                    if (matrix[i, col] < matrix[i + 1, col])
                    {
                        longTemp += matrix[i + 1, col];
                    }
                    else
                    {
                        break;
                    }
                }
                longestStr = LongestStrAlphabetical(longestStr, longTemp);
            }
            for (int row = size - 1; row >= 0; row--)
            {
                longTemp = "" + matrix[row, col];
                for (int i = row; i > 0; i--)
                {
                    if (matrix[i, col] < matrix[i - 1, col])
                    {
                        longTemp += matrix[i - 1, col];
                    }
                    else
                    {
                        break;
                    }
                }
                longestStr = LongestStrAlphabetical(longestStr, longTemp);
            }

        }
        Console.WriteLine(longestStr);
    }

    private static string LongestStrAlphabetical(string longestStr, string longTemp)
    {
        if ((longTemp.Length > longestStr.Length) || ((longTemp.Length == longestStr.Length && longTemp.CompareTo(longestStr) < 0)))
        {
            longestStr = longTemp;
        }
        return longestStr;
    }
}
