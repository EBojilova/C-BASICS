using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9PlayWithIntDoubleString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Pleace choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1: 
                    Console.WriteLine("Enter an integer number");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + num1);
                    break;
                case 2:
                    Console.WriteLine("Enter a double");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + num2);
                    break;
                case 3:
                    Console.WriteLine("Enter a string");
                    string str = Console.ReadLine();
                    Console.WriteLine("Result: " + str + "*");
                    break;
                default: 
                    Console.WriteLine("Invalid type!");
                    break;
            }
        }
    }
}
