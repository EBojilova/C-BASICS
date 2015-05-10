using System;

internal class NumbersInIntervalDividedbyGivenNumbger
{
    static void Main()
    {
        int a = Math.Abs(int.Parse(Console.ReadLine())); //Math.abs returns the absolut value of the number! So the program is going to work even if the user enters a negative value!
        int b = Math.Abs(int.Parse(Console.ReadLine()));
        int counter=0;
        for (int i = a; i <= b; i++)
        {
            if (i%5==0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}