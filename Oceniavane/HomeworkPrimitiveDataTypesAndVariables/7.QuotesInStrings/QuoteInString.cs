using System;

class QuoteInString
{
    static void Main()
    {
        string A = "The "use" of quotations causes difficulties.";
        string B = The "use" of quotations causes difficulties.;
        Console.WriteLine("The string in quoted is {0}, the string without is {1}", A, B);
    }
}
