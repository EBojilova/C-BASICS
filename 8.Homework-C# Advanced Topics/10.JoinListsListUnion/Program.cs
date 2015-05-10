using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main(string[] args)
    {
        List<int> list1 = Console.ReadLine().Split(' ').Select(token => int.Parse(token)).ToList(),
            list2 = Console.ReadLine().Split(' ').Select(token => int.Parse(token)).ToList();

        list1 = list1.Union(list2).ToList();
        list1.Sort();

        foreach (int number in list1)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}