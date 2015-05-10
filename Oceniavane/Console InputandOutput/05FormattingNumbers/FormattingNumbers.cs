using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0}|{1}|{2,10:0.00}|{3,-10:0.###}|", (a.ToString("X").PadRight(10,' ')), (Convert.ToString(a,2).PadLeft(10,'0')),b,c);
    }
}