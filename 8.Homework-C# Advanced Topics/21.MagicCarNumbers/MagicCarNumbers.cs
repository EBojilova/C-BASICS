using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16.MagicCarNumbers
{
    class MagicCarNumbers
    {
        static void Main(string[] args)
        {
            int magicWeight = int.Parse(Console.ReadLine());

            char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            int[] letterValue = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int count = 0;
            for (int p1 = 0; p1 <= 9; p1++)
            {
                for (int p2 = 0; p2 <= 9; p2++)
                {
                    for (int p3 = 0; p3 <= 9; p3++)
                    {

                        for (int p4 = 0; p4 <= 9; p4++)
                        {
                            if (((p1 == p2) && (p1 == p3) && (p4 == p1)) ||
                                ((p1 == p2) && (p1 == p3) && (p4 != p1)) ||
                                ((p4 == p2) && (p4 == p3) && (p4 != p1)) ||
                                ((p2 == p3) && (p1 == p4)) ||
                                ((p1 == p2) && (p3 == p4)) ||
                                ((p1 == p3) && (p2 == p4)))
                            {
                                for (int p5 = 0; p5 < letters.Length; p5++)
                                {
                                    for (int p6 = 0; p6 < letters.Length; p6++)
                                    {
                                        int weight = 40 + p1 + p2 + p3 + p4 + letterValue[p5] + letterValue[p6];

                                        if (weight == magicWeight)
                                        {
                                           // Console.WriteLine("CA{0}{1}{2}{3}{4}{5}", p1, p2, p3, p4, letters[p5], letters[p6]);
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
            // if (count == 0)
            //{
            //   Console.WriteLine("No");
            // }
        }
    }
}
