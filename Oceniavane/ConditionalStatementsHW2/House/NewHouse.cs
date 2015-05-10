﻿
/*Problem 15.* House
Ivaylo decided he needs a new house. Since he is not a structural engineer yet, you have
to help him construct the building from the ground zero.
The roof is a triangle. The walls are straight vertical lines. The base is a straight
horizontal line. The roof, the walls and the base of the house it build of '*'.
Everything else is filled with '.' (see the examples below to catch the idea).
You will be given an odd integer N, representing the width and the height of the house.
The roof’s top starts from the center (N+1)/2 and forms a triangle with base of width N.
The roof’s height is (N+1)/2. The distance between the roofs’ end point and the walls of
the building is N/4, rounded down to an integer number. See the examples below to
understand better these formulas.
Input
•	Input data is read from the console.
•	The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	You must print at the console a house of size N following the formulas above and the examples below.
Constraints
•	N will be an odd number between 5 and 49.
•	Time limit: 0.25 seconds.
•	Allowed memory: 16 MB.
Examples
Input	Output		Input	Output		Input	Output
5	    ..*..
        .*.*.
        *****
        .*.*.
        .***.		7	...*...
                        ..*.*..
                        .*...*.
                        *******
                        .*...*.
                        .*...*.
                        .*****.		        9	....*....
                                                ...*.*...
                                                ..*...*..
                                                .*.....*.
                                                *********
                                                ..*...*..
                                                ..*...*..
                                                ..*...*..
                                                ..*****..*/



using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 5 && n <= 49)
        {
            Console.WriteLine();
            Console.WriteLine(new string('.', n/2) + '*' + new string('.', n/2));
            for (int i = 0; i < n/2 - 1; i++)
            {
                Console.WriteLine(new string('.', (n / 2 - 1) - i) + '*' + 
                                  new string('.', 1+2*i) + '*' + 
                                  new string('.', (n / 2 - 1) - i));
            }
            Console.WriteLine(new string('*', n));
            for (int j = 0; j < n/2 - 1; j++)
            {
                if (n == 5)
                {
                    Console.WriteLine(new string('.', (n/2 - 1) - j) + '*' + 
                                  new string('.', n - 4) + '*' +
                                  new string('.', (n/2 - 1) - j));
                }
                else
                {
                    Console.WriteLine(new string('.', (n/2 - 2)) + '*' + 
                                  new string('.', 3) + '*' +
                                  new string('.', (n/2 - 2)));
                }
             }
             if (n == 5)
             {
                 Console.WriteLine('.' + "***" + '.');
             }
             else
             {
                 Console.WriteLine(new string('.', n/2 - 2) + "*****" + 
                                   new string('.', n/2 - 2));
             }
             Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}


