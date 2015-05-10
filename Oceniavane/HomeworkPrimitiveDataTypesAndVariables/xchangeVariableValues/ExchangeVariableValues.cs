using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The value of a is: {0}, the value of b is: {1}", a, b);
        a = a + b;
        b = a - b;
        Console.WriteLine("The value of a now is: {0}, the value of b now is: {1}", a, b);
    }
}
