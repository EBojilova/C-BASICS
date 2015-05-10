using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Number : ");
        long num = long.Parse(Console.ReadLine());
        string hexaStr = "";
        if (num == 0)
        {
            hexaStr = "0";
        }
        else
        {
            while (num >= 1)
            {
                if (num % 16 == 10)
                {
                    hexaStr = 'A' + hexaStr;
                }
                else if (num % 16 == 11)
                {
                    hexaStr = 'B' + hexaStr;
                }
                else if (num % 16 == 12)
                {
                    hexaStr = 'C' + hexaStr;
                }
                else if (num % 16 == 13)
                {
                    hexaStr = 'D' + hexaStr;
                }
                else if (num % 16 == 14)
                {
                    hexaStr = 'E' + hexaStr;
                }
                else if (num % 16 == 15)
                {
                    hexaStr = 'F' + hexaStr;
                }
                else
                {
                    hexaStr = (num % 16) + hexaStr;
                }
                num = num / 16;
            }
        }
        Console.WriteLine("The Hexadecimal format for given number is {0}", hexaStr);
    }
}

