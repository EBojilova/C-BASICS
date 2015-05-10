using System;

class CatchBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string binaryStr = "";
        string tempNum = "";
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            tempNum = Convert.ToString(num, 2).PadLeft(8, '0');
            binaryStr += tempNum;
        }
        int index = 1;
        char[] bits = binaryStr.ToCharArray();
        binaryStr = "";
        for (int i = 0; i < bits.Length; i++)
        {
            if (i == index)
            {
                index += step;
                binaryStr += bits[i];
            }
        }
        if (binaryStr.Length % 8 != 0)
        {
            binaryStr += new string('0', 8 - (binaryStr.Length % 8));
        }
        for (int i = 0; i < binaryStr.Length; i += 8)
        {
            string substringNumber = binaryStr.Substring(i, 8);
            Console.WriteLine(Convert.ToUInt32(substringNumber, 2));
        }
    }
}
