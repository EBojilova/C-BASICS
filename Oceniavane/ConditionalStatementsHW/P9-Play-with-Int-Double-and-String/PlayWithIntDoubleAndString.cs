using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Play_with_Int_Double_and_String
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            int choice=0;
            bool convert = false;

            while (!convert)
            {
                Console.Write("1 --> int\n2 --> double\n3 --> string\nEnter your chosen type: ");
                convert = int.TryParse(Console.ReadLine(), out choice) && choice>0 && choice<=3;
                if (!convert)
                {
                    Console.WriteLine("Error!");
                }
            }

            if(choice == 1)
            {
                int Integer=0;
                convert = false;
                while (!convert)
                {
                    Console.Write("Enter an integer: ");
                    convert = int.TryParse(Console.ReadLine(), out Integer);
                    if (!convert)
                    {
                        Console.WriteLine("Error!");
                    }
                }
                Console.WriteLine("Result: " + (Integer + 1));
            }
            else if (choice == 2)
            {
                double Float = 0;
                convert = false;
                while (!convert)
                {
                    Console.Write("Enter a double: ");
                    convert = double.TryParse(Console.ReadLine(), out Float);
                    if (!convert)
                    {
                        Console.WriteLine("Error!");
                    }
                }
                Console.WriteLine("Result: " + (Float + 1));
            }
            else if (choice == 3)
            {
                string inString = "";
                Console.Write("Enter a string: ");
                inString = Console.ReadLine();
                Console.WriteLine("Result: " + inString + "*");
            }
        }
    }
}
