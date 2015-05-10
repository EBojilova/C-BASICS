using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.LongSequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i * -1);
                }
            }
        }
    }
}
