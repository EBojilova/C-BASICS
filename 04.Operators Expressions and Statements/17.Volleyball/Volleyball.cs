using System;

    class Volleyball
    {
        static void Main()
        {
            
            //Console.Write("Please enter is the year is Leap or No:");
            string year= Console.ReadLine();
            //Console.Write("The number p – number of holidays in the year :");
            double p=Convert.ToUInt16(Console.ReadLine());
            //Console.Write("The number h – number of weekends that Vladi spends in his hometown:");
            double h = Convert.ToUInt16(Console.ReadLine());
            double k = (year=="Leap" ? 1.15 : 1.0);
            double playsPerYear =(uint)(((p*2)/3 +h+(3*(48 - h))/4)*k);
            Console.WriteLine(playsPerYear);
        }
    }

