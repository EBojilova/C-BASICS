using System;
using System.Collections.Generic;

class BasketBattle
{
    static void Main(string[] args)
    {
        Dictionary<string, int> players = new Dictionary<string, int>()
        {
            {"Simeon", 0},
            {"Nakov", 0},
           
        };
        string firstName = Console.ReadLine();
        string secondName = (firstName == "Simeon" ? "Nakov" : "Simeon");
        int roundsN = int.Parse(Console.ReadLine());
        for (int i = 1; i <= roundsN; i++)
        {
            
            int score = int.Parse(Console.ReadLine());
            string wasSuccess = Console.ReadLine();
            if (wasSuccess == "success")
            {
                players[firstName] += score;
                if (players[firstName] == 500)
                {
                    Console.WriteLine(firstName);
                    Console.WriteLine(i);
                    Console.WriteLine(players[secondName]);
                    return;
                }
                else if (players[firstName] > 500)
                {
                    players[firstName] -= score;
                }
            }
            score = int.Parse(Console.ReadLine());
            wasSuccess = Console.ReadLine();
            if (wasSuccess == "success")
            {
                players[secondName] += score;
                if (players[secondName] == 500)
                {
                    Console.WriteLine(secondName);
                    Console.WriteLine(i);
                    Console.WriteLine(players[firstName]);
                    return;
                }
                else if (players[secondName] > 500)
                {
                    players[secondName] -= score;
                }
            }
            firstName = (firstName == "Simeon" ? "Nakov" : "Simeon");
            secondName = (firstName == "Simeon" ? "Nakov" : "Simeon");
        }
        if (players[firstName] == players[secondName])
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(players[firstName]);
        }
        else
        {
            Console.WriteLine(players[firstName] > players[secondName]? firstName :secondName);
            Console.WriteLine(Math.Abs(players[firstName]-players[secondName]));
        }
    }
}
