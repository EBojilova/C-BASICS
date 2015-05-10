using System;

class QuotesInStrings
{
    static void Main()
    {
        string quotation = "The \"use\" of quotations causes difficulties.";
        string quotation2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(quotation);
        Console.WriteLine(quotation2);
    }
}

