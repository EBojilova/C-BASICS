using System;
using System.Collections.Generic;
using System.Linq;

class SequenceOfKnumbers
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ').ToList();
        int k = int.Parse(Console.ReadLine());
        bool sequenceTrue = true;
        for (int i = 0; i <numbers.Count-(k-1) ; i++)
        {
            sequenceTrue = true;
            for (int j = 1; j < k; j++)//i e poslednoto k
            {
                if (numbers[i]!=numbers[i+j])
                {
                    sequenceTrue = false;
                    break;
                }
            }
            if (sequenceTrue)
            {
                numbers.RemoveRange(i, k);
                i-- ;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
