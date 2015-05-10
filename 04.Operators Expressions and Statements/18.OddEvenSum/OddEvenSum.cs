using System;

class OddEvenSum
{
    static void Main(string[] args)
    {
        int n, nI = new int();
       int sumOdd=0;
        int sumEven=0;
        //Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (int.TryParse(nStr, out n)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        for (int i = 1; i <= 2*n; i++)
        {
            //Console.Write("num{0}: ", i);
            string nIstr = Console.ReadLine();
            if (int.TryParse(nIstr, out nI)) ;
            else
            {
                Console.WriteLine("out of range");
                return;
            }
            if (i % 2 ==1)
            {
                sumOdd += nI;
            }
            else if (i%2==0)
            {
                sumEven += nI;
            }
        }
        if (sumOdd==sumEven)
        {
            Console.WriteLine("Yes, sum={0}", sumOdd);
        }
        else
        {
            int diff = Math.Abs(sumOdd - sumEven);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
