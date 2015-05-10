using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class CalculateOne
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double factorial = 1;
        double result = 1;

        for (int index = 1; index <= n; index++)
        {
            factorial *= index;
            result += factorial / Math.Pow(x,index);
        
       
        }
        Console.WriteLine("{0:F5}",result);
    }  
}

    

