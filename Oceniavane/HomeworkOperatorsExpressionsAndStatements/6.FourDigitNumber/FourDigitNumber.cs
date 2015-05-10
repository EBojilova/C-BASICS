using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Number: {0}", number);

        int firstDigit = number % 10;
        number = number / 10;

        int secondDigit = number % 10;
        number = number / 10;

        int thirdDigit = number % 10;
        number = number / 10;

        int fourthDigit = number;

        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine("Sum of digits: {0}", sumOfDigits);

        Console.WriteLine("Reversed number: {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
        Console.WriteLine("Second and third digit exchanged: {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
    }
}

