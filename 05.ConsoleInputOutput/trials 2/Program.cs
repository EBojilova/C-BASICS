using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
/* Implement the "Falling Rocks" game in the text console.
 * A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
 * A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density.
 * The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system. */

class Object
{
    public Object()
    {
    }

    public Object(int x, int y, string body, ConsoleColor color)
    {
        this.X = x;
        this.Y = y;
        this.Body = body;
        this.Color = color;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public string Body { get; set; }
    public ConsoleColor Color { get; set; }
}

class Rock : Object
{
    private static string[] rockTypes = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
    private static ConsoleColor[] rockColors = {
                                                   ConsoleColor.Blue,
                                                   ConsoleColor.Cyan,
                                                   ConsoleColor.Gray,
                                                   ConsoleColor.Green,
                                                   ConsoleColor.Magenta,
                                                   ConsoleColor.Red,
                                                   ConsoleColor.White,
                                                   ConsoleColor.Yellow
                                               };
    Random rand = new Random();

    public Rock(int x, int y, string body, ConsoleColor color)
    {
        base.X = x;
        base.Y = y;
        base.Body = body;
        base.Color = color;
    }

    public Rock()
    {
        for (int i = 0; i <= 2; i++)
        {
            base.X = rand.Next(2, FallingRocks.playGroundWigth - 2);
        }
        base.Y = 0;
        base.Body = rockTypes[rand.Next(0, rockTypes.Length)];
        base.Color = rockColors[rand.Next(0, rockColors.Length)];
    }

    public bool Destroyed { get; set; }

    public void Fall()
    {
        ++base.Y;
    }

    public void destroy()
    {
        this.Destroyed = true;
    }
}

class Dwarf : Object
{
    public Dwarf()
    {
        this.Lives = 5;
        base.X = FallingRocks.playGroundWigth / 2 - 1;
        base.Y = FallingRocks.playGroundHeight;
        base.Body = "0^0";
        base.Color = ConsoleColor.Cyan;
    }

    public int Lives { get; set; }

    public void MoveLeft()
    {
        if (base.X > 2)
        {
            --base.X;
        }
    }

    public void MoveRight()
    {
        if (base.X < FallingRocks.playGroundWigth - 3)
        {
            ++base.X;
        }
    }

}

class Rocket : Object
{
    public Rocket()
    {
        base.X = 0;
        base.Y = 0;
        base.Body = "^";
        base.Color = ConsoleColor.Red;
        this.IsFired = false;
    }

    public bool IsFired { get; set; }

    public void moveUp()
    {
        if (base.Y > 1 && this.IsFired == true)
        {
            --base.Y;
        }
        else
        {
            this.IsFired = false;
        }
    }
}

class FallingRocks
{
    public static int consoleWidth = 90;
    public static int consoleHeight = 40;
    public static int playGroundWigth = 60;
    public static int playGroundHeight = 38;
    public static int startSpeed = 220;

    static void startMenu()
    {
        Console.BufferWidth = Console.WindowWidth = 95;
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 10);
        string[] logo =
        {
           "   ........ ... ......  .. . ............. ... ...       .. ........... ..................   " ,    
           "   . .MMMMM...MM...OM.  .OM,   .MMMMM.NMM..M..MMMM~      .MMMMM..MMMMM..MMMM..M..MI.MMMMM    " ,  
           "   . .MM.....OMNM..OM.  .OM, .   .M. .NMM..M.M.. ..       MN..M.NM. .M.MM.....M.M...MM....   " ,  
           "   . .MMMMM..M..M. OM.  .OM, .   .M. .NM.M.M.M..MM~      .MMMM..MM. .M.MN ....MMM.. ..MMM.   " ,    
           "   ...MM....MMMMMM OM....OM,......M...NM.NMM.MM..M~      .MM.MM.~M..MM.MM.. ..M.OM......M.   " ,    
           "   ...MM.. .M....M.OMMMM.OMMMMM.MMMMM.MM..MM..MMMM~      .MM..M8.OMMM...~MMM..M..MM.MMMM..   " ,
           "   ........ ... ......  .. . ............. ... ...       .. ........... ..................   " ,
        };

        for (int i = 0; i < logo.Length; i++)
        {
            Console.WriteLine(logo[i]);
        }
        Console.WriteLine("\n\n");
        Console.WriteLine("                                 SHOOT:        [UpArrow]");
        Console.WriteLine("                                 MOVE: [RightArrow][LeftArrow]\n\n");
        Console.WriteLine("                                    PRESS [ENTER] TO START");
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t\t\tIMPLEMENTED BY KOLIMNARED");
        Console.WriteLine("\t\t\t\t\t\t\t\t C# BASICS SEPTEMBER 2014");
        Console.ReadLine();
        Console.Clear();
    }

    static void printObject(Object obj)
    {
        Console.SetCursorPosition(obj.X, obj.Y);
        Console.ForegroundColor = obj.Color;
        Console.WriteLine(obj.Body);
    }

    static void clearPlayGround(int mode)
    {
        Console.ForegroundColor = ConsoleColor.Black;
        if (mode == 1)
        {
            Console.SetCursorPosition(2, 0);
            Console.WriteLine(new string(' ', playGroundWigth - 4));
            return;
        }
        Console.SetCursorPosition(playGroundWigth + 8, 17);
        Console.Write(new string(' ', 15));
    }

    static void displayMenuAndFrame(int lives, int speed, int level, int score)
    {
        int middleOfMenu = playGroundWigth + (consoleWidth - playGroundWigth) / 2;
        ConsoleColor defaulfColor = ConsoleColor.Yellow;
        Console.ForegroundColor = defaulfColor;
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i <= playGroundHeight; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("||{0}||       __________________", new string(' ', playGroundWigth - 4));
            }
            else if (i > 6 && i < 23)
            {
                Console.WriteLine("||{0}||      |                  |", new string(' ', playGroundWigth - 4));
            }
            else if (i == 23)
            {
                Console.WriteLine("||{0}||      |__________________|", new string(' ', playGroundWigth - 4));
            }
            else
            {
                Console.WriteLine("||{0}||", new string(' ', playGroundWigth - 4));
            }
        }
        Console.Write(new string('=', playGroundWigth));
        printObject(new Object(middleOfMenu - ("_____SCORE_____".Length / 2), 8, "_____SCORE_____", defaulfColor));
        printObject(new Object(middleOfMenu - (score.ToString().Length / 2), 9, score.ToString(), defaulfColor));

        printObject(new Object(middleOfMenu - ("_____LEVEL_____".Length / 2), 12, "_____LEVEL_____", defaulfColor));
        printObject(new Object(middleOfMenu - (level.ToString().Length / 2), 13, level.ToString(), defaulfColor));

        printObject(new Object(middleOfMenu - ("_PLAYERS LIVES_".Length / 2), 16, "_PLAYERS LIVES_", defaulfColor));
        string livesString = new string('*', lives);
        printObject(new Object(middleOfMenu - (livesString.Length / 2), 17, livesString, defaulfColor));

        printObject(new Object(middleOfMenu - ("_____SPEED_____".Length / 2), 20, "_____SPEED_____", defaulfColor));
        string speedString = new string('-', ((startSpeed - speed) / 15) + 1);
        printObject(new Object(middleOfMenu - (speedString.Length / 2), 21, speedString, defaulfColor));
    }

    static void Main(string[] args)
    {
        startMenu();
        Console.BufferWidth = Console.WindowWidth = consoleWidth;
        Console.BufferHeight = Console.WindowHeight = consoleHeight;
        Console.CursorVisible = false;
        Dwarf Toshko = new Dwarf();
        Rocket littleBoy = new Rocket();
        List<Rock> rocks = new List<Rock>();

        int level = 1;
        int score = 0;
        int speed = startSpeed;

        while (Toshko.Lives > 0)
        {
            displayMenuAndFrame(Toshko.Lives, speed, level, score < playGroundHeight ? 0 : score - 40);
            printObject(Toshko);
            if (littleBoy.IsFired == true)
            {
                printObject(littleBoy);
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    Toshko.MoveRight();
                }
                else if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    Toshko.MoveLeft();
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (littleBoy.IsFired == false)
                    {
                        littleBoy.IsFired = true;
                        littleBoy.X = Toshko.X + 1;
                        littleBoy.Y = Toshko.Y - 1;
                        printObject(littleBoy);
                    }
                }
            }

            Random rand = new Random();
            int rocksPerRow = rand.Next(1, 5 + level);

            for (int i = 0; i < rocksPerRow; i++)
            {
                Rock rock = new Rock();
                rocks.Add(rock);
            }

            bool collision = false;
            Rock hitedRock = new Rock(0, 0, "*", ConsoleColor.Red);
            for (int i = 0; i < rocks.Count; i++)
            {
                if (rocks[i].Y <= playGroundHeight)
                {
                    printObject(rocks[i]);
                }
                else
                {
                    rocks[i].destroy();
                }
                if ((rocks[i].Y == Toshko.Y) && (rocks[i].X >= Toshko.X && rocks[i].X <= Toshko.X + 2))
                {
                    collision = true;
                }
                if (littleBoy.IsFired == true && littleBoy.X == rocks[i].X &&
                    (littleBoy.Y == rocks[i].Y || littleBoy.Y == rocks[i].Y + 1))
                {
                    littleBoy.IsFired = false;
                    hitedRock.X = rocks[i].X;
                    hitedRock.Y = rocks[i].Y;
                    printObject(hitedRock);
                }

                if (rocks[i].Destroyed == true || (rocks[i].X == hitedRock.X && rocks[i].Y == hitedRock.Y))
                {
                    rocks.RemoveAt(i--);
                }
                else
                {
                    rocks[i].Fall();
                }
            }

            if (collision)
            {
                clearPlayGround(2);
                printObject(new Object(Toshko.X, Toshko.Y, "XXX", ConsoleColor.Red));
                Toshko.Lives--;
                Console.Beep();
            }

            if (littleBoy.IsFired)
            {
                littleBoy.moveUp();
            }

            if (((score - playGroundHeight) % 50 == 0) && (score > playGroundHeight) && (speed > 30))
            {
                speed -= 5;
            }
            if ((score - playGroundHeight) == Math.Pow(2, level) * 30)
            {
                level++;
            }

            score++;
            Thread.Sleep(speed);
            clearPlayGround(1);
        }
    }
}