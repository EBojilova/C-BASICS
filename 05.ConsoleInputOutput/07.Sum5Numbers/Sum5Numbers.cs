using System;

class Sum5Numbers
{
    static void Main()
    {
        double result = 0;
        double numberI = new double();
        Console.Write("Enter 5 numbers(given in a single line, separated by a space):");
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        for (int i = 0; i < numbers.Length; i++)
        {

            if (double.TryParse(numbers[i], out numberI))
            {
                result += numberI;
            }
            else
            {
                Console.WriteLine("out of range");
                return;
            }
        }
        Console.WriteLine("Sum: {0}", result);
    }
}

