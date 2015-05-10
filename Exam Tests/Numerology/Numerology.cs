using System;

class Numerology
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] { '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        long result = 1;
        for (int i = 0; i < input.Length - 1; i++)
        {
            result *= int.Parse(input[i]);
        }
        if (int.Parse(input[1]) % 2 == 1)
        {
            result *= result;
        }
        string name = input[3];
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] >= 64 && name[i] <= 90)
            {
                result += (name[i] - 64) * 2;
            }
            else if ((name[i] >= 97 && name[i] <= 122))
            {
                result += name[i] - 96;
            }
            else if (((name[i] >= 48 && name[i] <= 57)))
            {
                result += name[i] - 48;
            }
        }
        while (result > 13)
        {
            long sum = 0;
            while (result > 0)
            {
                sum += result % 10;
                result /= 10;
            }
            result = sum;
        }
        Console.WriteLine(result);
    }
}
