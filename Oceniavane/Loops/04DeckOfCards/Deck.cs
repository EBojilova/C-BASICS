using System;
class Deck
{
    static void Main()
    {
        string[] array = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == "10")
            {
                Console.WriteLine("{0}♣  {0}♦  {0}♥  {0}♥ ", array[i]);
            }
            else
            {
                Console.WriteLine(" {0}♣   {0}♦   {0}♥   {0}♥ ", array[i]);
            }

        }
    }
}