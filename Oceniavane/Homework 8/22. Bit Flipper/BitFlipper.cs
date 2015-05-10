using System;

class BitFlipper
{
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong mask = (7ul << 61);// ne raboti
        Console.WriteLine(Convert.ToString((long)mask, 2).PadLeft(64, '0'));

        while (mask > 3)
        {
            ulong check = number & mask;
            Console.WriteLine(Convert.ToString((long)check, 2).PadLeft(64, '0'));
            if (check == mask || check == 0)
            {
                number ^= mask;
                mask >>= 3;
            }
            else
            {
                mask >>= 1;
            }
            Console.WriteLine(Convert.ToString((long)number, 2).PadLeft(64, '0'));
        }

        Console.WriteLine(number);
    }
}