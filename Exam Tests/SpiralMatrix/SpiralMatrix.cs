using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        int  row, col = new int();
        int counter = 0;
        //Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        string word = Console.ReadLine();
        word = word.ToUpper();
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n / 2; i++)
        {
            for (col = 0 + i, row = 0 + i; col < n - i; col++)
            {
                matrix[row, col] = word[counter % word.Length];
                counter++;
            }
            for (col = n - 1 - i, row = 1 + i; row < n - i; row++)
            {
                matrix[row, col] = word[counter % word.Length];
                counter++;
            }
            for (col = n - 2 - i, row = n - 1 - i; col >= 0 + i; col--)
            {
                matrix[row, col] = word[counter % word.Length];
                counter++;
            }
            for (col = 0 + i, row = n - 2 - i; row >= 1 + i; row--)
            {
                matrix[row, col] = word[counter % word.Length];
                counter++;
            }
        }
        if (n % 2 == 1)
        {
            matrix[n / 2, n / 2] = word[counter % word.Length];
        }
        int maxSum = int.MinValue;
        int rowMax=-1;
        int sum = 0;
        for (row = 0; row < n; row++)
        {
            sum = 0;
            for (col = 0; col < n; col++)
            {
                sum += (matrix[row, col]-64);
                    //Console.Write("{0} ", (char)matrix[row, col]);
            }
            if (sum>maxSum)
            {
                maxSum = sum;
                rowMax = row;
            }
            //Console.WriteLine();
        }
        Console.WriteLine("{0} - {1}", rowMax, maxSum * 10);
    }
}
