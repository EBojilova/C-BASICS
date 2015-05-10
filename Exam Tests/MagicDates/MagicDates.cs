using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

class MagicDates
{
    static void Main(string[] args)
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endtDate = new DateTime(endYear, 12, 31);
        bool thereAreDates = false;
        for (DateTime i = startDate; i <= endtDate; i = i.AddDays(1))
        {
            string dateI = i.ToString("ddMMyyyy", CultureInfo.InvariantCulture);
            //Console.WriteLine(dateI);
            int weight = 0;
            for (int j = 0; j < dateI.Length; j++)
            {
                //Console.Write(dateI[j]+" ");
                int numJ = dateI[j]-'0';
                for (int k = j + 1; k < dateI.Length; k++)
                {
                    int numK = dateI[k]-'0';
                    weight += numJ * numK;
                }
            }
            if (weight == diff)
            {
                Console.WriteLine(i.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture));
                thereAreDates = true;
            }
        }
        if (!thereAreDates)
        {
            Console.WriteLine("No");
        }
    }
}
