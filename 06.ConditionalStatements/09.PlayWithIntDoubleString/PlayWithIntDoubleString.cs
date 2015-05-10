using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                {
                    Console.WriteLine("Please enter an int:");
                    string inputIntStr = Console.ReadLine();
                    int inputInt = int.Parse(inputIntStr);
                    Console.WriteLine(inputInt+1);
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Please enter a double:");
                    string inputDoubleStr = Console.ReadLine();
                    double inputDouble = double.Parse(inputDoubleStr);
                    Console.WriteLine(inputDouble+1);
                    break;
                }
            case "3":
                {
                    Console.WriteLine("Please enter a string:");
                    string inputStr = Console.ReadLine();
                    Console.WriteLine("{0}{1}",inputStr, "*");
                    break;
                }
        }
    }
}

