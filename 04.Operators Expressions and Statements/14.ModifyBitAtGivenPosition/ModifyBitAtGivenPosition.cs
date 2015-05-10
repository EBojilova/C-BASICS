using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("p: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("v: ");
        int v = Convert.ToInt32(Console.ReadLine());
        if (v == 1)
        {
            int maskLeftP = 1 << p;
            Console.Write(n | maskLeftP);

        }
        else
        {
            int maskLeftP = ~(1 << p);
            Console.WriteLine(n & maskLeftP);
        }
    }
}
/*using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            int number;
            string numberString = Console.ReadLine();
            if (!Int32.TryParse(numberString, out number))
            {
                Console.Write("Not a number or integer number !");
                return;
            }
            int pos;
            string posString = Console.ReadLine();
            if (!Int32.TryParse(posString, out pos))
            {
                Console.Write("Not a number or integer number !");
                return;
            }
            int v;
            string vString = Console.ReadLine();
            if (!Int32.TryParse(vString, out v))
            {
                if (v > 1 || v < 0)
                {
                    return;
                }
                Console.Write("Not a number or integer number !");
                return;
            }
            int nthBit = (number >> pos) & 1;
            if (nthBit == v)
            {
                Console.WriteLine(number);
                return;
            }
            if (nthBit == 0)
            {
                number = number + (int) Math.Pow(2, pos);
            }
            else
            {
                number = number - (int) Math.Pow(2, pos);
            }
            Console.WriteLine(number);
        }
    }
}
*/
