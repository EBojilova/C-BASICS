using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputElem = input.Split(' ');

            int firstElem = int.Parse(inputElem[0]);
            int secondElem = int.Parse(inputElem[1]);
            int prevValue = firstElem + secondElem;

            int diffMax = 0;
            for (int i = 2; i < inputElem.Length - 1; i += 2)
            {
                firstElem = int.Parse(inputElem[i]);
                secondElem = int.Parse(inputElem[i + 1]);
                int lastValue = firstElem + secondElem;
                int diffCur = Math.Abs(lastValue - prevValue);
                diffMax = Math.Max(diffCur, diffMax);
                prevValue = lastValue;
            }

            if (diffMax == 0)
            {
                Console.WriteLine("Yes, value=" + prevValue);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + diffMax);
            }
        }
    }
}
