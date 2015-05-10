using System;

internal class FormmatingNumbers
{
    static void Main()
    {
        int a;
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 499) 
            Console.WriteLine("Invalid input!!!");
        float b;
        while (!float.TryParse(Console.ReadLine(), out b) || a < 0 || a > 499) 
            Console.WriteLine("Invalid input!!!");
        float c;
        while (!float.TryParse(Console.ReadLine(), out c) || a < 0 || a > 499) 
            Console.WriteLine("Invalid input!!!");
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
        // Според мен резултатът в домашното, има някаква грешка... но моето решение мисля, че си е правилно :) проблемите са във форматирането на b и c 
    }
}