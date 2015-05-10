using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.NumberComparer
{
    class Problem04NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double greaterNumber = Math.Max(firstNumber, secondNumber);

            Console.WriteLine("greater number is: " + greaterNumber);
        }
    }
}
