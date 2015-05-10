using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.BitFlipper
{
    class BitFlipper
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string binaryStr = (ConvertToBinary(n)).PadLeft(64, '0');
            //Console.WriteLine(binaryStr);
            char[] bits = binaryStr.ToCharArray();
            int i = 0;
            while (i < bits.Length - 2)
            {
                if (bits[i] == '0' && bits[i + 1] == '0' && bits[i + 2] == '0')
                {
                    bits[i] = '1';
                    bits[i + 1] = '1';
                    bits[i + 2] = '1';
                    i += 3;
                }
                else if (bits[i] == '1' && bits[i + 1] == '1' && bits[i + 2] == '1')
                {
                    bits[i] = '0';
                    bits[i + 1] = '0';
                    bits[i + 2] = '0';
                    i += 3;
                }
                else
                {
                    i++;
                }
            }
            binaryStr = new string(bits);
            //Console.WriteLine(binaryStr.PadLeft(64,'0'));
            Console.WriteLine(Convert.ToUInt64(binaryStr,2));
        }
        public static string ConvertToBinary(ulong value)
        {
            if (value == 0) return "0";
            System.Text.StringBuilder b = new System.Text.StringBuilder();
            while (value != 0)
            {
                b.Insert(0, ((value & 1) == 1) ? '1' : '0');
                value >>= 1;
            }
            return b.ToString();
        }
    }
}
