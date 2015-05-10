using System;

class NumbersNotDivisible3and7
{
    static void Main()
    {
        int n = new int();
        Console.Write("n: ");
        string nStr = Console.ReadLine();
        if (int.TryParse(nStr, out n)) ;
        else
        {
            Console.WriteLine("out of range");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 | i % 7 == 0) ;
            else
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
/*        for (int index = 1; index <= number; index++)
        {
            if (index % 3 == 0 || index % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", index);
        }
*/
