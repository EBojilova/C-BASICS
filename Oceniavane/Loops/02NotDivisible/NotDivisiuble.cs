using System;


class NotDivisible
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        int number = int.Parse(Console.ReadLine());

        for (int index = 1; index <= number; index++)
        {
            if (index % 3 == 0 || index % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", index);
        }

    }
}
