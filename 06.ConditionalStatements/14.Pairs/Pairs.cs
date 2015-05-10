using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] elements = input.Split(' ');
            int doubleNumI2, diff = new int();
            int doubleNumI = 0;
            int maxDiff = 0;
            if (elements.Length > 2)
            {
                for (int i = 0; i < elements.Length - 3; i += 2)
                {
                    doubleNumI = int.Parse(elements[i]) + int.Parse(elements[i + 1]);
                    doubleNumI2 = int.Parse(elements[i + 2]) + int.Parse(elements[i + 3]);
                    diff = Math.Abs(doubleNumI2 - doubleNumI);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }

            }
            else
            {
                doubleNumI = int.Parse(elements[0]) + int.Parse(elements[1]);
            }
            if (maxDiff > 0)
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value={0}", doubleNumI);
            }
        }
    }
}
/*string input = Console.ReadLine();
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
            }*/