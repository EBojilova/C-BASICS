using System;

class Triangle
{
    static void Main()
    {
        char A = '\u00A9';
        Console.WriteLine("   {0}\n" + "  {0} {0}\n" + " {0}   {0}\n" + "{0} {0} {0} {0}", A.ToString());
    }
}
