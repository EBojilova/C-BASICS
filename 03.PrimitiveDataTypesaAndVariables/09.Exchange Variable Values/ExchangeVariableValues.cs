using System;

class ExchangeVariableValues
{
    static void Main()
    {
        sbyte n1 = 5;
        sbyte n2 = 10;
        Console.WriteLine("Before exchanging: \n a={0} \n b={1}", n1, n2);
        sbyte exchange = n1;
        n1 = n2;
        n2 = exchange;
        Console.WriteLine("After exchanging: \n a={0} \n b={1}", n1, n2);
    }
}

