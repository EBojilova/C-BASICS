using System;

class DivideBy7And5
{
    static void Main()
    {
        Random r = new Random();
        int rInt = r.Next(-200, 200);
        //rInt = 35;
        if((rInt % 7 == 0) && (rInt % 5 == 0))
        {
            Console.WriteLine("{0} is divide by 7 and 5", rInt);
        }
        else
        {
            Console.WriteLine("{0} is not divide by 7 and 5", rInt);
        }
    }
}
