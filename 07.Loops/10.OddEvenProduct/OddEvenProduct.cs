using System;

class OddEvenProduct
{
    static void Main()
    {
        int nI = new int();
        int prodOdd = 1;
        int prodEven = 1;
        //Console.Write("n integers (given in a single line, separated by a space): ");
        string input = Console.ReadLine();
        string[] nStr = input.Split();
        for (int i = 1; i <= nStr.Length; i++)
        {
            if (int.TryParse(nStr[i-1], out nI)) ;
            else
            {
                Console.WriteLine("out of range");
                return;
            }
            if (i % 2 == 1)
            {
                prodOdd *= nI;
            }
            else if (i % 2 == 0)
            {
                prodEven *= nI;
            }
        }
        if (prodOdd == prodEven)
        {
            Console.WriteLine("yes,");
            Console.WriteLine("product = {0}", prodOdd);
        }
        else
        {
            int diff = Math.Abs(prodOdd - prodEven);
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", prodOdd);
            Console.WriteLine("even_product = {0}", prodEven);
        }
    }
}

