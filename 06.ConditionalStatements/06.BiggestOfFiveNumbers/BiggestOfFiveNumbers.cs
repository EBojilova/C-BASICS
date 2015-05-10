using System;

class BiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        double a, b, c, d, e = new double();
        Console.Write("a: ");
        string aStr = Console.ReadLine();
        if (double.TryParse(aStr, out a)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        Console.Write("b: ");
        string bStr = Console.ReadLine();
        if (double.TryParse(bStr, out b)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        Console.Write("c: ");
        string cStr = Console.ReadLine();
        if (double.TryParse(cStr, out c)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        Console.Write("d: ");
        string dStr = Console.ReadLine();
        if (double.TryParse(dStr, out d)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        Console.Write("e: ");
        string eStr = Console.ReadLine();
        if (double.TryParse(eStr, out e)) ;
        else
        {
            Console.WriteLine("out of range");
        }
        if (a >= b & a >= c & a >= d & a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= a & b >= c & b >= d & b >= e)
        {
            Console.WriteLine(b);
        }
        else if (c >= a & c >= b & c >= d & c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= a & d >= b & d >= c & d >= e)
        {
            Console.WriteLine(d);
        }
        else if (e >= a & e >= b & e >= c & e >= d)
        {
            Console.WriteLine(e);
        }
    }
}

/*double a = 0, max = double.MinValue;
            //input validation

            for (int i = 0; i < 5; i++)
            {
                bool convert = false;
                while (!convert)
                {
                    Console.Write("Enter number {0} : ",(i+1));
                    convert = double.TryParse(Console.ReadLine(), out a);
                    if (!convert)
                    {
                        Console.Write("Error! ");
                    }
                }

                if (a > max)
                {
                    max = a;
                }
            }
            Console.WriteLine("The biggest number is: " + max);*/
