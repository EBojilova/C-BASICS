using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a Number : ");
        long num = long.Parse(Console.ReadLine());
        string binaryStr = "";
        if (num == 0)
        {
            binaryStr = "0";
        }
        else
        {
            while (num >= 1)
            {
                binaryStr = (num % 2)+binaryStr;
                num = num / 2;
            }
        }
        Console.WriteLine("The Binary format for given number is {0}", binaryStr);
    }
}

