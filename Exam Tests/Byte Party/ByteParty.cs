using System;

class ByteParty
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        uint[] numbers = new uint[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }
        string inputLine;
        string command;
        int index;
        while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "party over"))
        {
            string[] input = inputLine.Split(' ');
            command = input[0];
            index = int.Parse(input[1]);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (command == "-1")
                {
                    numbers[i] ^= (1u << index);
                }
                else if (command == "0")
                {
                    numbers[i] &= ~(1u << index);
                }
                else if (command == "1")
                {
                    numbers[i] |= (1u << index);
                }
            }
        }
        foreach (var item in numbers)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
