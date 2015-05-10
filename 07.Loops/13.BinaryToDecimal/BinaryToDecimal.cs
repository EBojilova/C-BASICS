using System;

class BinaryToDecimal
{
    static void Main()
    {
        int two = 1;
        int num = 0;
        string binaryNum = Console.ReadLine();
        for (int i = binaryNum.Length - 1; i >= 0; i--)
        {
            num += (binaryNum[i] - 48) * two;
            two *= 2;
        }
        Console.WriteLine(num);
    }
}

