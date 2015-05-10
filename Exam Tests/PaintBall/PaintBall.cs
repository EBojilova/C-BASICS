using System;
using System.Linq;

class PaintBall
{
    static void Main(string[] args)
    {
        int[] matrix = new int[] { 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023, 1023 };
        string inputLine;
        int counter = 1;
        while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "End"))
        {
            string[] input = inputLine.Split(' ');
            int shootRow = int.Parse(input[0]);
            int shootCol = int.Parse(input[1]);
            int shootRadius = int.Parse(input[2]);
            int startColIndex = ((shootCol - shootRadius) >= 0 ? shootCol - shootRadius : 0);
            int endColIndex = ((shootCol + shootRadius) <= 9 ? shootCol + shootRadius : 9);
            int startRowIndex = ((shootRow - shootRadius) >= 0 ? shootRow - shootRadius : 0);
            int endRowIndex = ((shootRow + shootRadius) <= 9 ? shootRow + shootRadius : 9);
            for (int j = startRowIndex; j <= endRowIndex; j++)
            {
                for (int i = startColIndex; i <= endColIndex; i++)
                {
                    if (counter % 2 == 0)
                    {
                        matrix[j] |= 1 << i;
                    }
                    else
                    {
                        matrix[j] &= ~(1 << i);
                    }
                }
                //Console.WriteLine(Convert.ToString( matrix[j], 2).PadLeft(10, '0'));
            }
            counter++;
        }
        int sum = matrix.Sum();
        Console.WriteLine(sum);
    }
}
