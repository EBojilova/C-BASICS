using System;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int newNumber = 0;
        int iNew = 0;
        for (int i = 0, iAll = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
            for (int iCurrent = 7; iCurrent >= 0; iCurrent--)
            {
                if ((iAll - 1) % step == 0 && iAll != 0)
                {
                    int currentBit = (num >> iCurrent) & 1;
                    newNumber = (newNumber << 1) | currentBit;
                    iNew++;
                    if (iNew % 8 == 0)
                    {
                        Console.WriteLine(newNumber);
                        //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(8, '0'));
                        newNumber = 0;
                    }
                }
                iAll++;
            }
        }
        if (iNew % 8 != 0)
        {
            newNumber = newNumber << (8 - iNew % 8);
            Console.WriteLine(newNumber);
            //Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(8, '0'));
        }
    }
}
