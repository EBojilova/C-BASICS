using System;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
            for (int bit = 7; bit >= 0; bit--)
            {
                if (index % step == 0)
                {
                    num = num ^ (1 << bit);
                }
                index++;
            }
           // Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
            Console.WriteLine(num);
        }
    }
}
