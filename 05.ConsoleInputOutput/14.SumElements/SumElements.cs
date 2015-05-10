using System;

class SumElements
{
    static void Main()
    {
        ulong result = 0;
        ulong max = 0;
        ulong numberI = new ulong();
        //Console.Write("Enter N numbers(given in a single line, separated by a space):");
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        for (int i = 0; i < numbers.Length; i++)
        {
            numberI = uint.Parse(numbers[i]);
            result += numberI;
            if (numberI > max)
            {
                max = numberI;
            }

        }
        if (result == 2 * max)
        {
            Console.WriteLine("Yes, sum={0}", max);
        }
        else
        {
            if (result > 2 * max && result - 2 * max != 0)
            {
                Console.WriteLine("No, diff={0}", result - 2 * max);
            }
            else
            {
                Console.WriteLine("No, diff={0}", 2 * max - result);
            }

        }
    }
}

