using System;
class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] tempArray = new int[input.Length];
        int sum = 0;

        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = int.Parse(Convert.ToString(input[i]));
        }

        Array.Reverse(tempArray);

        for (int i = 0, j = 1; i < tempArray.Length; i++, j *= 2)
        {
            sum += tempArray[i] * j;
        }
        Console.WriteLine(sum);
    }
}