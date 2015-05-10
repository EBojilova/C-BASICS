using System;

class WorkHours
{
    static void Main()
    {
        int hourseRequired = int.Parse(Console.ReadLine());
        int inputDays = int.Parse(Console.ReadLine());
        int productivityInput = int.Parse(Console.ReadLine());
        double productivity = productivityInput / 100.00; 
        double days = inputDays - (inputDays * 0.1);
        int workHours = (int)(days * 12 * productivity);
        int needHours = workHours - hourseRequired;

        if (needHours < 0)
        {
            Console.WriteLine("No");
            Console.WriteLine(needHours);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(needHours);
        }
    }
}

