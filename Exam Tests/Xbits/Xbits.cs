using System;

class DoubleDowns
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] matrix = new int[n];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = int.Parse(Console.ReadLine());
        }
        int counterRight = 0;
        int counterLeft = 0;
        int counterVertical = 0;
        int top = new int();
        int bottomMiddle = new int();
        int bottomLeft = new int();
        int bottomRight = new int();
        for (int j = 0; j < 32; j++)
        {
            for (int i = 0; i < (matrix.Length - 1); i++)
            {

                top = (matrix[i] >> j) & 1;
                if (j - 1 >= 0)
                {
                    bottomRight = (matrix[i + 1] >> (j - 1)) & 1;
                    if (top == 1 && bottomRight == 1)
                    {
                        counterRight++;
                    }
                }
                bottomLeft = (matrix[i + 1] >> (j + 1)) & 1;
                if (top == 1 && bottomLeft == 1)
                {
                    counterLeft++;
                }
                bottomMiddle = (matrix[i + 1] >> j) & 1;
                if (top == 1 && bottomMiddle == 1)
                {
                    counterVertical++;
                }
            }
        }
        Console.WriteLine(counterRight);
        Console.WriteLine(counterLeft);
        Console.WriteLine(counterVertical);
    }
}
