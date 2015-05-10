using System;
using System.Collections.Generic;
using System.Linq;

class EncryptTheMessages
{
    static void Main(string[] args)
    {
        string inputLine;
        int countMessage = 0;
        char[] symbols = new char[] { ' ', ',', '.', '?', '!' };
        char[] newSymbols = new char[] { '+', '%', '&', '#', '$' };
        bool hasStart = false;
        string[] messages = new string[100];
        //while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "Game Over!"))
        while (true)
        {
            inputLine = Console.ReadLine();
            while ((inputLine.ToLower()) == "start" || hasStart)
            {
                hasStart = true;
                inputLine = Console.ReadLine();
                if (!(string.IsNullOrEmpty(inputLine) || inputLine.ToLower() == "end"))
                {
                    countMessage++;
                    char[] message = inputLine.ToCharArray();
                    for (int i = 0; i < message.Length; i++)
                    {
                        if (message[i] >= 'a' && message[i] <= 'm')
                        {
                            message[i] = (char)(message[i]+13);
                        }
                        else if (message[i] >= 'n' && message[i] <= 'z')
                        {
                            message[i] = (char)(message[i] - 13);
                        }
                        else if (message[i] >= 'A' && message[i] <= 'M')
                        {
                            message[i] = (char)(message[i] + 13);
                        }
                        else if (message[i] >= 'N' && message[i] <= 'Z')
                        {
                            message[i] = (char)(message[i] - 13);
                        }
                        for (int j = 0; j < symbols.Length; j++)
                        {
                            if (message[i]==symbols[j])
                            {
                                message[i] = newSymbols[j];
                            }
                        }
                    }
                    Array.Reverse(message);
                    string messageStr = new string(message);
                    messages[countMessage] = messageStr;
                }
                else if (inputLine.ToLower() == "end")
                {
                    break;
                }
            }
            if (inputLine.ToLower() == "end")
            {
                break;
            }
        }
        if (countMessage>0)
        {
            Console.WriteLine("Total number of messages: {0}", countMessage);
            for (int i = 0; i < messages.Length; i++)
            {
                if (messages[i] != null)
                {
                    Console.WriteLine(messages[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("No messages sent.");
        }
    }
}
