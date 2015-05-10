using System;

class ThirdDigit7
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int thirdDijit = number / 100 % 10;
        Console.WriteLine(thirdDijit == 7);
    }
}

