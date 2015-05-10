/*
Write a program that takes as input two lists of names and removes from the first list
all names given in the second list. The input and output lists are given as words,
separated by a space, each list at a separate line. Examples:

Input											Output
Peter Alex Maria Todor Steve Diana Steve		Peter Alex Maria Diana
Todor Steve Nakov

Hristo Hristo Nakov Nakov Petya					Hristo Hristo Petya
Nakov Vanessa Maria
*/
using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    // bez using System.Linq;
    static bool Contains(string[] list, string toFind)
    {
        foreach (string item in list)
        {
            if (item == toFind)
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        string[] listOfNames = Console.ReadLine().Split(' '),
            namesToRemove = Console.ReadLine().Split(' ');

        List<string> output = new List<string>();

        foreach (string name in listOfNames)
        {
            if (!namesToRemove.Contains(name))
            {
                output.Add(name);
                // moje napravo da se otpe4atvat tuk
            }
        }

        foreach (string name in output)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}