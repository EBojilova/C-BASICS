using System;

class BitLock
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int[] matrix = new int[numbers.Length];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = int.Parse(numbers[i]);
        }
        string inputLine;
        while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "end"))
        {
            int counter = 0;
            string[] comand = inputLine.Split(' ');
            if (comand[0] == "check")
            {
                int col = int.Parse(comand[1]);
                for (int i = 0; i < matrix.Length; i++)
                {
                    counter += matrix[i] >> col & 1;
                }
                Console.WriteLine(counter);
            }
            if (comand.Length > 2)
            {
                int row = int.Parse(comand[0]);
                int rotations = (int.Parse(comand[2])) % 12;
                int mask = (1 << rotations) - 1;
                int mask12bits = 0 | ((1 << 12) - 1);
                //Console.WriteLine(Convert.ToString(mask12bits, 2).PadLeft(32, '0'));
                //Console.WriteLine(Convert.ToString(matrix[row], 2).PadLeft(32, '0'));
                if (comand[1] == "right")
                {
                    matrix[row] = matrix[row] >> (rotations) | matrix[row] << (12 - (rotations));
                }
                else if (comand[1] == "left")
                {
                    matrix[row] = matrix[row] << (rotations) | matrix[row] >> (12 - (rotations));
                }
                //Console.WriteLine(Convert.ToString(matrix[row], 2).PadLeft(32, '0'));
                matrix[row] &= mask12bits;
                //Console.WriteLine(Convert.ToString(matrix[row], 2).PadLeft(32, '0'));
            }
        }
        Console.WriteLine(String.Join(" ", matrix));
    }
}
