using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.InsideBuilding
{
    class InsideBuilding
    {
        static void Main(string[] args)
        {
            double h = Convert.ToDouble(Console.ReadLine());
            string[] resultsAll = new string[5];
            for (int i = 0; i < 5; i++)
            {
                //Console.Write("Please enter x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                //Console.Write("Please enter y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                bool inTower = (1 * h <= x && x <= 2 * h && 1 * h <= y && y <= 4 * h);
                bool inBase = (0 <= x && x <= 3 * h && 0 <= y && y <= 1 * h);
                resultsAll[i] = (inTower || inBase ? "inside" : "outside");
            }
            foreach (var result in resultsAll)
            {
                Console.WriteLine(result);
            }
        }
    }
}
