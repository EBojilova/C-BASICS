using System;

    class BitsExchange
    {
        static void Main()
        {
            uint value, mask1, mask2, result = new uint();
            Console.Write("Enter integer: ");
            value = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Binary value:  " + Convert.ToString(value, 2).PadLeft(32, '0'));
            mask1 = value & 56;
            Console.WriteLine("Mask1:         " + Convert.ToString(mask1, 2).PadLeft(32, '0'));
            mask2 = value & 117440512;
            Console.WriteLine("Mask2:         " + Convert.ToString(mask2, 2).PadLeft(32, '0'));
            uint mask1OrMask2 = mask1 | mask2;
            Console.WriteLine("Mask12:        " + Convert.ToString(mask1OrMask2, 2).PadLeft(32, '0'));
            result = value ^ (mask1 | mask2);
            Console.WriteLine("BeforeEXCHANG: " + Convert.ToString(result, 2).PadLeft(32, '0'));
            result |= mask1 << 21;
            result |= mask2 >> 21;
            Console.WriteLine("Binary result: " + Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("Result: " + result);
        }
    }

/*using System;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            uint number;
            string numberString = Console.ReadLine();
            if (!UInt32.TryParse(numberString, out number))
            {
                Console.Write("Not a number or integer number !");
                return;
            }
            uint bit3 = (number >> 3) & 1;
            uint bit4 = (number >> 4) & 1;
            uint bit5 = (number >> 5) & 1;
            uint bit24 = (number >> 24) & 1;
            uint bit25 = (number >> 25) & 1;
            uint bit26 = (number >> 26) & 1;
            if (bit3 == 0)
            {
                if (bit24 == 1)
                {
                    number = number - (uint)Math.Pow(2, 24) + (uint)Math.Pow(2, 3);
                }
            }
            else
            {
                if (bit24 == 0)
                {
                    number = number + (uint)Math.Pow(2, 24) - (uint)Math.Pow(2, 3);
                }
            }
            if (bit4 == 0)
            {
                if (bit25 == 1)
                {
                    number = number - (uint)Math.Pow(2, 25) + (uint)Math.Pow(2, 4);
                }
            }
            else
            {
                if (bit25 == 0)
                {
                    number = number + (uint)Math.Pow(2, 25) - (uint)Math.Pow(2, 4);
                }
            }
            if (bit5 == 0)
            {
                if (bit26 == 1)
                {
                    number = number - (uint)Math.Pow(2, 26) + (uint)Math.Pow(2, 5);
                }
            }
            else
            {
                if (bit26 == 0)
                {
                    number = number + (uint)Math.Pow(2, 26) - (uint)Math.Pow(2, 5);
                }
            }
            Console.WriteLine(number);
        }
    }
}
*/