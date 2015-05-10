using System;

class Pairs
{
    static void Main(string[] args)
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), s => int.Parse(s));
        int prevSum = numbers[0] + numbers[1];
        int maxDiff = 0;
        for (int i = 2; i < numbers.Length - 1; i += 2)
        {
            int sum = numbers[i] + numbers[i + 1];
            int diff = Math.Abs(prevSum - sum);
            maxDiff = Math.Max(diff, maxDiff);
            prevSum = sum;
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", prevSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
