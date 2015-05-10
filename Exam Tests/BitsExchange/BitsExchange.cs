using System;

class BitsExchange2
{
    static void Main()
    {
        uint value, maskP, maskQ, result, p, q, k, numKI = new uint();
        uint numK = 1;
        Console.Write("Enter integer: ");
        string valueStr = Console.ReadLine();
        if (uint.TryParse(valueStr, out value)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("Enter start point p: ");
        string pStr = Console.ReadLine();
        if (uint.TryParse(pStr, out p)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("Enter start point q: ");
        string qStr = Console.ReadLine();
        if (uint.TryParse(qStr, out q)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        Console.Write("Enter numebr of the bits to be exchanged k: ");
        string kStr = Console.ReadLine();
        if (uint.TryParse(kStr, out k)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("out of range");
            return;
        }
        else if (Math.Min(p, q) + k >= Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
            return;
        }
        for (uint i = 1; i < k; i++)
        {
            numKI = 1u << (int)i;
            numK = numK | numKI;
        }
        Console.WriteLine(numK);
        Console.WriteLine("Binary K:      " + Convert.ToString(numK, 2).PadLeft(32, '0'));
        Console.WriteLine("Binary value:  " + Convert.ToString(value, 2).PadLeft(32, '0'));
        maskP = value & numK << (int)p;
        Console.WriteLine("MaskP:         " + Convert.ToString(maskP, 2).PadLeft(32, '0'));
        maskQ = value & numK << (int)q; ;
        Console.WriteLine("MaskQ:         " + Convert.ToString(maskQ, 2).PadLeft(32, '0'));
        uint maskPOrMaskQ = maskP | maskQ;
        Console.WriteLine("MaskPQ:        " + Convert.ToString(maskPOrMaskQ, 2).PadLeft(32, '0'));
        result = value ^ (maskP | maskQ);
        Console.WriteLine("BeforeEXCHANG: " + Convert.ToString(result, 2).PadLeft(32, '0'));
        int diffPQ = Math.Abs((int)(p - q));
        Console.WriteLine(diffPQ);
        if (q > p)
        {
            result |= maskP << diffPQ;
            result |= maskQ >> diffPQ;
        }
        else
        {
            result |= maskP >> diffPQ;
            result |= maskQ << diffPQ;
        }
        Console.WriteLine("Binary result: " + Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Result: " + result);
    }
}

