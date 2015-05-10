using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("28");
        int age = Convert.ToInt16(Console.ReadLine());
        int futureAge = age + 10;
        Console.WriteLine("38", futureAge);
    }
}