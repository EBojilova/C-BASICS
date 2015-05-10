using System;

    class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1: Console.WriteLine("Please enter an int: ");
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine(i + 1);
                    break;
                case 2: Console.WriteLine("Please enter a double: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine(x + 1);
                    break;
                case 3: Console.WriteLine("Please enter a string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                        break;
            }
        }
    }

