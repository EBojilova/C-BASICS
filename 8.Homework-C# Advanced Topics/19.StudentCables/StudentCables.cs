using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.StudentCables
{
    class StudentCables
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cableLength;
            string measurement;
            int sumLenght = 0;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                cableLength = int.Parse(Console.ReadLine());
                measurement = Console.ReadLine();
                if (measurement == "meters")
                {
                    cableLength *= 100;
                }
                if (cableLength >= 20)
                {
                    sumLenght += cableLength;
                    counter++;
                }
            }
            double studentCables = Math.Floor((sumLenght - 3.0 * (counter - 1)) / 504);
            double rest = sumLenght - 3 * (counter - 1) - studentCables * 504;
            Console.WriteLine(studentCables);
            Console.WriteLine(rest);
        }
    }
}
