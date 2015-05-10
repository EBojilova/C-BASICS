using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter 4-digit number: ");
        int fourDigitNum = Convert.ToInt32(Console.ReadLine());
        int firstDigit = fourDigitNum / 1000 % 10;
        int secondDigit = fourDigitNum / 100 % 10;
        int thidDigit = fourDigitNum / 10 % 10;
        int fourthDigit = fourDigitNum / 1 % 10;
        int sum = firstDigit + secondDigit + thidDigit + fourthDigit;
        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thidDigit, secondDigit, firstDigit);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thidDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, thidDigit, secondDigit, fourthDigit);
    }
}

