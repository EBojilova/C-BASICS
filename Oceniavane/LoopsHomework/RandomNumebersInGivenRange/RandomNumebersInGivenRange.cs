using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RandomNumebersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int random = rnd.Next(min,max);
        for (int i = 0; i < n; i++)
        {

            Console.Write("{0} ", rnd.Next(random));
        }
    }
}

