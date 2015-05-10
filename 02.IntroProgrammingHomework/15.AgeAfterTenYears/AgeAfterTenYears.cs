using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age:");
        int Age = int.Parse(Console.ReadLine());
        int result = Age + 10;
        Console.WriteLine("Your age after 10 years will be:" + result);

    }

}

