using System;

class BitPaths
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[8, n+1];
        for (int col = 1; col <= n; col++)
        {
            string[] commands = Console.ReadLine().Split(',');
            int tempNum = 0;
            for (int row = 0; row < commands.Length; row++)
            {
                if (row==0)
                {
                    int indexPath = int.Parse(commands[0]);

                    tempNum ^= 1 << (3 - indexPath);
                }
                else
                {
                    if (commands[row] == "-1")
                    {
                        tempNum <<= 1;
                    }
                    else if (commands[row] == "+1")
                    {
                        tempNum >>= 1;
                    }
                }
                matrix[row, col] = matrix[row, col - 1] ^ tempNum;
                //string numStr = Convert.ToString(matrix[row, col], 2).PadLeft(32, '0');
                //Console.WriteLine(numStr);
            }
        }
        int sum = 0;
        for (int row = 0; row < 8; row++)
        {
            sum += matrix[row, n];
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine("{0:X}",sum);
    }
}
