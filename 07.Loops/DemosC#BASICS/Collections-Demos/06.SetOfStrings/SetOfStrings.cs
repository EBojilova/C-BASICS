using System;
using System.Collections.Generic;
using System.Linq;

class SetOfStrings
{
    static void Main()
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Pesho");
        names.Add("Mario");
        names.Add("Sylvie");
        names.Add("Pesho");

        HashSet<string> newStudents = new HashSet<string> { "Gosho", "Peter", "Kim" };

        names.UnionWith(newStudents); //Combining the two sets in one without duplicates

        Console.WriteLine("Combined student sets:");
        foreach (string name in names)
        {
            Console.WriteLine(name); // Pesho, Mario, Sylvie, Gosho, Peter, Kim
        }

        HashSet<string> expelledStudents = new HashSet<string> { "Peter", "Mario"};


        names.ExceptWith(expelledStudents);

        Console.WriteLine("\nStudent's set without expelled students:");
        names.ToList().ForEach(s => Console.WriteLine(s));
    }
}