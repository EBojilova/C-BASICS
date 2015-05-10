using System;

class IsInCircleOutOfRectangle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
 
        bool IsInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool IsOutOfRectangle = (x > 1 || x < 6) && (y > -1 || y < 2);
        Console.WriteLine(IsOutOfRectangle);
 
       /* if (x == 0 || y == 0)
        {
            Console.WriteLine("no");
        }
        else if (IsInCircle == true && IsOutOfRectangle == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        */
    }
}

