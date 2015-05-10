using System;

class BooleanVariable
{
    static void Main(string[] args)
    {
        int male=1;
        int feMale = 2;
        bool isFemale = (male < feMale);
        Console.WriteLine("My gender is female: {0}", isFemale);
    }
}

