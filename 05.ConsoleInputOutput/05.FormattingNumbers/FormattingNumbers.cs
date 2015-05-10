using System;

class FormattingNumbers
{
    static void Main()
    {
        ushort a, aCheck = new ushort();
        double b, c = new double();
        Console.Write("Enter a: ");
        string aStr = Console.ReadLine();
        if (ushort.TryParse(aStr, out aCheck) && (aCheck <= 500u))
        {
            a = aCheck;
        }
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("Enter b: ");
        string bStr = Console.ReadLine();
        if (!double.TryParse(bStr, out b))
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("Enter c: ");
        string cStr = Console.ReadLine();
        if (double.TryParse(cStr, out c))
            if ((c - Math.Round(c)) == 0 && (b - Math.Round(b)) == 0)
            {
                Console.WriteLine("|{0,-10:X}|{3}|{1,10}|{2,-10}|", a, b, c, Convert.ToString(a, 2).PadLeft(10, '0'));
            }
            else if ((c - Math.Round(c)) == 0 && (b - Math.Round(b)) != 0)
            {
                Console.WriteLine("|{0,-10:X}|{3}|{1,10:F2}|{2,-10}|", a, b, c, Convert.ToString(a, 2).PadLeft(10, '0'));
            }
            else if ((c - Math.Round(c)) != 0 && (b - Math.Round(b)) == 0)
            {
                Console.WriteLine("|{0,-10:X}|{3}|{1,10}|{2,-10:F3}|", a, b, c, Convert.ToString(a, 2).PadLeft(10, '0'));
            }
            else
            {
                Console.WriteLine("|{0,-10:X}|{3}|{1,10:F2}|{2,-10:F3}|", a, b, c, Convert.ToString(a, 2).PadLeft(10, '0'));
            }
        else
        {
            Console.WriteLine("out of range");
            return;
        }
    }
}

