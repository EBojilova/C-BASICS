using System;

internal class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(a, b)); // В класа Math им доста полезни функции! Препоръчвам, да ги разгледаш! 
    }
}