using System;

class StringAndObjects
{
    static void Main()
    {
        string Hello = "Hello";
        string World = "World";
        object sum = (Hello + " " + World);
        string A = (string)sum;
        Console.WriteLine("A = {0}", A);
    }
}
