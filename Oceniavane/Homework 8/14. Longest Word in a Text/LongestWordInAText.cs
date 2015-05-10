/*
Write a program to find the longest word in a text. Examples:

Input										Output
Welcome to the Software University.			University

The C# Basics course is awesome start		programming
in programming with C# and Visual Studio.
*/
using System;
using System.Collections.Generic;

class LongestWordInAText
{
    static void Main(string[] args)
    {
        char[] separators = { ' ', '.', ',', '!', '\"', '\'' };
        string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int longestWordIndex = 0;

        for (int i = 1; i < input.Length; ++i)
        {
            if (input[longestWordIndex].Length < input[i].Length)
            {
                longestWordIndex = i;
            }
        }

        Console.WriteLine(input[longestWordIndex]);
    }
}