using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.BitRoller
{
    class BitRoller
    {
        static void Main(string[] args)
        {
            //The number n will be a 19-bit unsigned integer (in the range [0…524287]).
            //Pillar f  [0…18].
            //Roller r  [0…100].
            int n = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
            int nStart = n;
            if ((n>>f) % 2==1)
            {
                n = n & ~(1 << f);
            }
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
            for (int i = 1; i <= r; i++)
            {
                if (n % 2 == 1)
                {
                    n = n >> 1 | 1 << 18;
                }
                else
                {
                    n = n >> 1;
                }
                if ((n >> f) % 2 == 1)
                {
                    n = n | (1 << (f-1));
                    n = n & ~(1 << f);
                }
                //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
            }
            if ((nStart >> f) % 2 == 1)
            {
                n = n | 1 << f;
            }
            else
            {
                n = n & ~(1 << f);
            }
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
            Console.WriteLine(n);
        }
    }
}
