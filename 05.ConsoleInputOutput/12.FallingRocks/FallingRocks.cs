using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


struct item
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor colour;
}
class FallingRocks
{
    //Method, which will print ot choosen position of the screen
    static void PrintOnPosition(int x, int y, string c, ConsoleColor colour = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = colour;
        Console.Write(c);
    }

    static void Main()
    {

        //See the video Демонстрация- писане на игра JustCars to learn how to write the game.

        //Making the same size the Buffer and the Widnow so there are no scrow bars
        Console.BufferHeight = Console.WindowHeight = 32;
        Console.BufferWidth = Console.WindowWidth = 75;
        Console.BackgroundColor = ConsoleColor.Black;

        // Instructions for playing the game
        Console.WriteLine();
        Console.WriteLine("INSTRUCTIONS FOR PLAYING THE GAME");
        Console.WriteLine();
        Console.WriteLine("Move the dwarf (O) using <-- and --> keys to avoid the falling rocks. ");
        Console.WriteLine();
        Console.WriteLine("Your lives will decrease if the (O) get hitted by the rocks.");
        Console.WriteLine();
        Console.WriteLine("Your lives will increase if the (O) avoid rocks with in the time.");
        Console.WriteLine();
        Console.WriteLine("You will WIN if your lives become 10.");
        Console.WriteLine();
        Console.WriteLine("You will LOOSE if your lives become 0.");
        Console.WriteLine();
        Console.WriteLine("ENJOY, THE GAME!");
        Console.WriteLine();
        Console.WriteLine("Press ENTER to start the game.");
        Console.ReadLine();

        //Memory allocation for the drawf and rocks(container, colours, symbols)
        item dwarf = new item();
        dwarf.x = (Console.WindowWidth - 1) / 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = "(O)";
        dwarf.colour = ConsoleColor.White;
        Random generatorRocks = new Random();
        List<item> rocks = new List<item>();
        string rockChars = "^@*&%$#!.;-";
        ConsoleColor[] rockColours = { ConsoleColor.Cyan, ConsoleColor.DarkYellow, ConsoleColor.Green, 
                                         ConsoleColor.Red, ConsoleColor.Yellow };
        int livesCount = 5;
        int lifeBonus = 0;

        // Endless operator
        while (livesCount > 0 & livesCount < 10)
        {

            // Clear the console
            Console.Clear();

            lifeBonus++;

            // Genrating new rock
            item newRock = new item();
            newRock.colour = ConsoleColor.Blue;
            newRock.x = generatorRocks.Next(0, Console.WindowWidth - dwarf.c.Length);
            newRock.y = 2;
            int rockCharPostion = generatorRocks.Next(0, rockChars.Length);
            int rockLength = generatorRocks.Next(1, 4);
            newRock.c = new string((rockChars[rockCharPostion]), rockLength);
            int rockColourPostion = generatorRocks.Next(0, rockColours.Length);
            newRock.colour = rockColours[rockColourPostion];
            rocks.Add(newRock);

            // Move dwarf left and rigth
            //Check if here is pressed key, if not we continue to the rest of the program
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x -= 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < Console.WindowWidth - dwarf.c.Length)
                    {
                        dwarf.x += 1;
                    }
                }
            }


            // Moving rocks
            bool hitted = false;
            for (int i = 0; i < rocks.Count; i++)
            {
                if (dwarf.y == rocks[i].y)
                {
                    int rockStart = rocks[i].x;
                    int rockEnd = rockStart + rocks[i].c.Length - 1;
                    int dwarfStart = dwarf.x;
                    int dwarfEnd = dwarf.x + dwarf.c.Length - 1;
                    hitted = !((rockEnd < dwarfStart) || (rockStart > dwarfEnd));
                    if (hitted)
                    {
                        --livesCount;
                    }
                }

                item tempraryRock = new item();
                item rockI = rocks[i];
                tempraryRock.x = rockI.x;
                tempraryRock.y = rockI.y + 1;
                tempraryRock.colour = rockI.colour;
                tempraryRock.c = rockI.c;


                if (tempraryRock.y <= Console.WindowHeight - 1)
                {
                    rocks.Add(tempraryRock);
                }
                rocks.Remove(rocks[i]);
            }
            // Check if the rocks are hitting the dwarf



            // Redraw playfield


            if (hitted)
            {
                rocks.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, "CRASH", ConsoleColor.Red);

            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.colour);
            }

            foreach (item rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.c, rock.colour);
            }
            // Draw info
            if (lifeBonus % 60 == 0)
            {
                ++livesCount;
            }
            PrintOnPosition(0, 0, "Lives: " + livesCount, ConsoleColor.White);
            // Slow down program
            Thread.Sleep(150);
        }
        PrintOnPosition(10, 10, "GAME OVER!", ConsoleColor.Red);
        if (livesCount <= 0)
        {
            PrintOnPosition(10, 12, "SORRY, YOU LOST!", ConsoleColor.Red);
        }
        else if (livesCount >= 10)
        {
            PrintOnPosition(10, 12, "CONGRATULATIONS, YOU WON!", ConsoleColor.Red);
        }
        PrintOnPosition(10, 14, "Press ENTER fo finish the game.", ConsoleColor.Red);
        Console.WriteLine();

    }
}
