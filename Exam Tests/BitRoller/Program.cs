using System;

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
        int pillar = n & (1 << f);
        n &= ~pillar;
       // Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
        for (int i = 0; i < r; i++)
        {
            int digit0 = n & 1;
            n >>= 1;
            n |= digit0 << 18;
            int digitF = (n >> f) & 1;
            if (digitF == 1)
            {
                n ^= digitF << f;
                n |= 1 << (f - 1);
            }
           // Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
        }
        n |= pillar;
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
        Console.WriteLine(n);
    }
}
