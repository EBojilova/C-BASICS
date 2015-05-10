using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            long sixteen = 1;
            long num = 0;
            string hexNum = Console.ReadLine();
            for (int i = hexNum.Length - 1; i >= 0; i--)
            {
                if (hexNum[i] == 'A')
                {
                    num += 10 * sixteen;
                }
                else if (hexNum[i] == 'B')
                {
                    num += 11 * sixteen;
                }
                else if (hexNum[i] == 'C')
                {
                    num += 12 * sixteen;
                }
                else if (hexNum[i] == 'D')
                {
                    num += 13 * sixteen;
                }
                else if (hexNum[i] == 'E')
                {
                    num += 14 * sixteen;
                }
                else if (hexNum[i] == 'F')
                {
                    num += 15 * sixteen;
                }
                else
                {
                    num += (hexNum[i]-48)* sixteen;
                }
                sixteen *= 16;
            }
            Console.WriteLine(num);
        }
    }
}
