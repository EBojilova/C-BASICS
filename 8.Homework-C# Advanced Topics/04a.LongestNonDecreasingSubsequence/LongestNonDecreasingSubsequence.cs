using System;
using System.Collections.Generic;
using System.Linq;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        //The last three examples contradicts to the task that's why my program returns different Output.
        Console.WriteLine("Enter a sequence of integers on a line, separated by a space:");
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int n;
            bool nParse = int.TryParse(input[i], out n);
            if (!nParse)
            {
                Console.WriteLine("invalid input");
                return;
            }
            numbers[i] = n;
        }

        List<int> allNonDecreasing = new List<int>();
        List<int> longest = new List<int>();
        string output = Convert.ToString(numbers[0]);
        int max = 1;
        for (int i = 0; i < numbers.Length - 1; i++) //for-loop for all elements of the input except the last element
        {
            allNonDecreasing.Add(numbers[i]); // add to allNonDecreasing all elements bigger than the element [i], placed from the right side of element [i]
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] <= numbers[j])
                {
                    allNonDecreasing.Add(numbers[j]);
                }
            }
            int allVariations = (int)Math.Pow(2, allNonDecreasing.Count) - 1;
            while (allVariations > 0) //checking all variations where bit == 1
            {
                longest.Add(numbers[i]);
                for (int j = 1; j < allNonDecreasing.Count; j++)
                {
                    if (((allVariations >> allNonDecreasing.Count - j) & 1) == 1 && allNonDecreasing[j] >= longest.Last())
                    {
                        longest.Add(allNonDecreasing[j]);
                    }
                }
                if (longest.Count > max)
                {
                    output = string.Join(" ", longest);
                    max = longest.Count;
                }
                allVariations--;
                longest.Clear();
            }
            allNonDecreasing.Clear();
        }
        Console.WriteLine(output);
    }
}