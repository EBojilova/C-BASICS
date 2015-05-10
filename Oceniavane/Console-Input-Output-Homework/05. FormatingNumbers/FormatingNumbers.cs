using System;

class FormatingNumbers
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        int inputA = int.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double inputB = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double inputC = double.Parse(Console.ReadLine());

        string aHex = inputA.ToString("X");
        string aBinary = Convert.ToString(inputA, 2);
        string b = inputB.ToString("0.00");
        string c = inputC.ToString("0.000");
        
        Console.WriteLine("|"
                        + aHex 
                        + new string(' ', 10 - aHex.Length) 
                        + "|" 
                        + new string('0', 10 - aBinary.Length)
                        + aBinary
                        + "|"
                        + new string(' ', 10 - b.Length)
                        + b 
                        + "|" 
                        + c 
                        + new string(' ', 10 - c.Length)
                        + "|");
    }
}

