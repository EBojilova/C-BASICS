using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        for (int i = 0, iAll = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
            for (int iCurrent = 7; iCurrent >= 0; iCurrent--)
            {
                if ((iAll - 1) % step == 0 && iAll != 0)
                {
                    num |= 1 << iCurrent;
                }
                iAll++;
            }
            Console.WriteLine(num);
        }
    }
}
