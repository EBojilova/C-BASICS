using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        number = (number / 100);
        if(number % 10 == 7)
        {
            Console.WriteLine("The third digit of number is 7.");
        }
        else
        {
            Console.WriteLine("The third digit of number is not 7.");
        }
    }
}
