using System;
using System.Text; // We must use this library so we can use the ENCODING property

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        UTF8Encoding utf8 = new UTF8Encoding();
        //string copywrightX = "\u00a9";
        //string copywright = "©";
        Console.WriteLine("   \u00A9   ");
        Console.WriteLine("  \u00A9 \u00A9  ");
        Console.WriteLine(" \u00A9   \u00A9 ");
        Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
    }
}

/* int n = 4;
            char f = '\u00A9';
            char mqsto = ' ';
            for (int j = 0; j < n; j++)
            {
                if (j < 1)
                {
                    Console.WriteLine("{0}{1}", new string(mqsto, n - 1), new string(f, 1));
                }
                else if (j < 2)
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string(mqsto, n - 2), new string(f, 1), new string(mqsto, n - 3), new string(f, 1));
                }
                else if (j < 3)
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string(mqsto, n - 3), new String(f, 1), new string(mqsto, n - 1), new string(f, 1));
                }
                else if (j == 3)
                {

                    Console.WriteLine("{0}{1}{0}{1}{0}{1}{0}", new string(f, 1), new string(mqsto, 1));
                }
            }
*/