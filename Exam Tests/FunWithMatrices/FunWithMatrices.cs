using System;

class FunWithMatrices
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        int row, col = new int();
        double[,] matrix = new double[4, 4];

        for (row = 0; row < 4; row++)
        {
            for (col = 0; col < 4; col++)
            {
                matrix[row, col] = n;
                //Console.Write("  {0,7:F2}",matrix[row, col]);
                n += step;
            }
            //Console.WriteLine();
        }
        string inputLine;
        while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "Game Over!"))
        {
            string[] input = inputLine.Split(' ');
            row = int.Parse(input[0]);
            col = int.Parse(input[1]);
            double value = double.Parse(input[3]);
            if (input[2] == "power")
            {
                matrix[row, col] = Math.Pow(matrix[row, col], value);
            }
            else if (input[2] == "multiply")
            {
                matrix[row, col] *= value;
            }
            else if (input[2] == "sum")
            {
                matrix[row, col] += value;
            }
            //Console.WriteLine("matrix[{0},{1}]={2}",row, col, matrix[row, col]);
        }
        double sum;
        string printInfo = "";
        double maxSum = double.MinValue;
        for (row = 0; row < 4; row++)
        {
            sum = 0;
            for (col = 0; col < 4; col++)
            {
                sum += matrix[row, col];
            }
            if (maxSum < sum)
            {
                maxSum = sum;
                printInfo = string.Format("ROW[{0}] = {1:F2}", row, sum);
            }
        }
        for (col = 0; col < 4; col++)
        {
            sum = 0;
            for (row = 0; row < 4; row++)
            {
                sum += matrix[row, col];

            }
            if (maxSum < sum)
            {
                maxSum = sum;
                printInfo = string.Format("COLUMN[{0}] = {1:F2}", col, sum);
            }
        }
        sum = 0;
        for (row = 0; row < 4; row++)
        {
            sum += matrix[row, row];
        }
        if (maxSum < sum)
        {
            maxSum = sum;
            printInfo = string.Format("LEFT-DIAGONAL = {0:F2}", sum);
        }
        sum = 0;
        for (row = 0; row < 4; row++)
        {
            sum += matrix[row, 3 - row];

        }
        if (maxSum < sum)
        {
            maxSum = sum;
            printInfo = string.Format("RIGHT-DIAGONAL = {0:F2}", sum);
        }
        Console.WriteLine(printInfo);
    }
}
