using System;

class BonusScore
{
    static void Main()
    {
        int bonus = new int();
        Console.WriteLine("bonus (1 to 9): ");
        string bonusStr = Console.ReadLine();
        if (int.TryParse(bonusStr, out bonus))
        {
            if (bonus < 1 | bonus > 9)
            {
                Console.WriteLine("invalid score");
            }
            else if (bonus >= 1 & bonus <= 3)
            {
                bonus = bonus * 10;
                Console.WriteLine(bonus);
            }
            else if (bonus >= 4 & bonus <= 6)
            {
                bonus = bonus * 100;
                Console.WriteLine(bonus);
            }
            else if (bonus >= 7 & bonus <= 9)
            {
                bonus = bonus * 1000;
                Console.WriteLine(bonus);
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

