using System;
namespace _QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            double coeffA = double.Parse(inputStr);
            inputStr = Console.ReadLine();
            double coeffB = double.Parse(inputStr);
            inputStr = Console.ReadLine();
            double coeffC = double.Parse(inputStr);
            double discriminantD = (coeffB * coeffB) - (4 * coeffA * coeffC);
            double root1;
            double root2;
            if (discriminantD > 0)
            {
                root1 = (-coeffB + Math.Sqrt(discriminantD)) / (2 * coeffA);
                root2 = (-coeffB - Math.Sqrt(discriminantD)) / (2 * coeffA);
                Console.WriteLine("Two real roots.");
                Console.WriteLine(root1);
                Console.WriteLine(root2);
            }
            else if (discriminantD == 0)
            {
                root1 = root2 = (-coeffB - Math.Sqrt(discriminantD)) / (2 * coeffA);
                Console.WriteLine("One real root.");
                Console.WriteLine(root1);
            }
            else
            {
                Console.WriteLine("No real roots.");
            }
        }
    }
}