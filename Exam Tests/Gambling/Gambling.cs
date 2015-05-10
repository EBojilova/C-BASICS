using System;

class Gambling
{
    static void Main()
    {
        decimal cash= decimal.Parse(Console.ReadLine());
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] cardsHouse = (Console.ReadLine()).Split(' ');
        string[] currentFace = new string[4];
        int valueHouse = CalcValue(cardsHouse);

        long winningHands = 0;
        long possibleHands = 0; // 13^4=28561
        for (int d1 = 0; d1 < cards.Length; d1++)
        {
            for (int d2 = 0; d2 < cards.Length; d2++)
            {
                for (int d3 = 0; d3 < cards.Length; d3++)
                {
                    for (int d4 = 0; d4 < cards.Length; d4++)
                    {
                        currentFace[0] = cards[d1];
                        currentFace[1] = cards[d2];
                        currentFace[2] = cards[d3];
                        currentFace[3] = cards[d4];
                        int value = CalcValue(currentFace);
                        if (value>valueHouse)
                        {
                            winningHands++;
                        }
                        possibleHands++;
                    }
                }
            }
        }
        decimal chance = (decimal)(winningHands) / possibleHands;
        if (chance < 0.5m)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
        Console.WriteLine("{0:F2}", chance * cash * 2);
    }

    private static int CalcValue(string[] str)
    {
        int value = 0;
        foreach (var symbol in str)
        {
            switch (symbol)
            {
                case "10": value += 10; break;
                case "J": value += 11; break;
                case "Q": value += 12; break;
                case "K": value += 13; break;
                case "A": value += 14; break;
                default: value += int.Parse(symbol); break;
            }
        }
        return value;
    }
}
