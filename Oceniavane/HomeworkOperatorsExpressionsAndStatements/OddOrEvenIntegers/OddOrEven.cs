using System;

class OddOrEven
{
    static void Main()
    {
        Random r = new Random();
        int rInt = r.Next(-2000, 2000);

        bool IsOdd = true;

        if(rInt % 2 == 0)
        {
            IsOdd = false;        
        }
        Console.WriteLine("{0} is odd number: " + IsOdd, rInt);
    }
}
