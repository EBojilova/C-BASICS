using System;

class BitBuilder
{
    static void Main(string[] args)
    {
        ulong n = ulong.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        string inputLine;
        string command;
        int index;
        while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "quit"))
        {
            command = Console.ReadLine();
            if (command == "skip")
            {
                continue; 
            }
            index = int.Parse(inputLine);
            ulong newNum = 0;
            ulong currentNum;
            if (command == "flip")
            {
                newNum = n^(1UL << index);
            }
            else if (command == "insert")
            {
                for (int i = 0, iNew = 0; i < 64; i++, iNew++)
                {
                    if (iNew == index)
                    {
                        i--;
                        newNum |= 1u << iNew;
                    }
                    else
                    {
                        currentNum = (n >> i) & 1;
                        newNum |= currentNum << iNew;
                    }
                }
            }
            else if (command == "remove")
            {
                for (int i = 0, iNew = 0; i < 64; i++, iNew++)
                {
                    if (iNew == index)
                    {
                        i++;
                    }
                    currentNum = (n >> i) & 1;
                    newNum |= currentNum << iNew;
                }
            }
            n = newNum;
            //Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        }
            Console.WriteLine(n);
    }
}
