using System;

class GameOfBits
{
    static void Main(string[] args)
    {
        uint number = uint.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        string command;
        uint count1 = 0;
        while (!(string.IsNullOrEmpty(command = Console.ReadLine()) || command == "Game Over!"))
        {
            uint newNum = 0;
            uint currentNum;
            if (command == "Even")
            {
                number >>= 1;
            }
            for (int i = 0, iNew = 0; i < 32; i += 2, iNew++)
            {
                currentNum = (number >> i) & 1;
                newNum |= currentNum << iNew;
            }
            number = newNum;
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
        for (int i = 0; i < 32; i++)
        {
            count1 += (number >> i) & 1;
        }
        Console.WriteLine("{0} -> {1}", number, count1);
    }
}
