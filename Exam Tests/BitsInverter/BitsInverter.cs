using System;

namespace BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            // sistemata mi dade 73/100 tochki-da go prerabotia
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            ulong number = new ulong();
            for (int i = 0; i < n; i++)
            {
                ulong num = ulong.Parse(Console.ReadLine());
                //Console.WriteLine(Convert.ToString((long)num, 2).PadLeft(8, '0'));
                number = (number << 8) | num;
                //Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(n * 8, '0'));
            }
            
            for (int i = 8*n-1; i >= 0; i-=step)
            {
                number ^= (1ul << i);
            }
           // Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(n * 8, '0'));
            ulong mask = (1 << 8) - 1;
            //Console.WriteLine(Convert.ToString((long)mask, 2).PadLeft(8, '0'));
            for (int i = n - 1; i >= 0; i --)
            {
                ulong subNum = (number >> i*8) & mask ;
                Console.WriteLine(subNum);
                //Console.WriteLine(Convert.ToString((long)subNum, 2).PadLeft(8, '0'));
            }
        }
    }
}
