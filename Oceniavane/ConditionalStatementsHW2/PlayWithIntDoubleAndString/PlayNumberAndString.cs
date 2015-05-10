
/*Problem 9.	Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int,
double or string variable. If the variable is int or double, the program
increases it by one. If the variable is a string, the program appends "*"
at the end. Print the result at the console. Use switch statement. Example:
program	user		program	user
Please choose a type:           Please choose a type:
1 --> int                       1 --> int
2 --> double                    2 --> double
3 --> string	        3       3 --> string            2    		

Please enter a string:	hello	Please enter a double:	1.5
hello*			                2.5*/


using System;

class PlayNumberAndString
{
    static void Main()
    {
        Console.WriteLine("Make a selection 1, 2, 3, and press key enter");
        Console.WriteLine("Please choose a type: ");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string number = Console.ReadLine();
        switch (number)
        {
            case "1": 
                Console.Write("Enter a int number and press key enter, intNumber = ");
                int varInt = int.Parse(Console.ReadLine());
                varInt = varInt + 1;
                Console.WriteLine("Result: {0}", varInt);
                break;
            case "2": 
                Console.Write("Enter a double number and press key enter, doubleNumber = ");
                double varDouble = double.Parse(Console.ReadLine());
                varDouble = varDouble + 1;
                Console.WriteLine("Result: {0}", varDouble);
                break;
            case "3":
                Console.Write("Enter a string and press key enter, string: ");
                string varString = Console.ReadLine();
                Console.WriteLine("Result: " + varString + "*");
                break;
        }
    }
}

