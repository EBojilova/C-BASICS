using System;

class WorkHours
{
    static void Main()
    {
        //Console.Write("Number of hours required to finish the projec:");
        double h = double.Parse(Console.ReadLine());
        //Console.Write("The days that Lelia Vanche has available for working :");
        double d = double.Parse(Console.ReadLine());
        //Console.WriteLine("Her average productivity during the given period in percent:");
        double p = double.Parse(Console.ReadLine());
        double workVanche = (int)(d * 12 * 0.9 * (p / 100));
        if (workVanche >= h)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(workVanche - h);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(workVanche - h);
        }
    }
}

