using System;
using System.Text;

class PrintASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        UTF8Encoding utf8 = new UTF8Encoding();
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine("The number {0} is {1} in ASCII", i, (char)i);
        }
    }
}

/*Console.OutputEncoding = Encoding.ASCII;


            int column = 0;
            for (byte counter = 32; counter < 128; counter++)
            {
                if (column == 0)
                {
                    Console.Write("0x{0:X}  ", counter);
                }
                Console.Write(" {0}  ", (char)counter);
                if (++column > 7)
                {
                    column = 0;
                    Console.WriteLine();
                }

            }
            Console.ReadLine();*/