using System;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            sum += num;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}