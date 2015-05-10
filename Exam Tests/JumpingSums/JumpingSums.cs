using System;

class JumpingSums
{
    static void Main(string[] args)
    {
        string[] numbersStr = Console.ReadLine().Split();
        int[] nums = Array.ConvertAll(numbersStr, int.Parse);
        int jumps = int.Parse(Console.ReadLine());
        int maxSum = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int index = i;
            int sum = nums[index];
            for (int j = 0; j < jumps; j++)
            {
                index = (index + nums[index]) % (nums.Length);
                sum += nums[index];
            }
            if (sum>maxSum)
            {
                maxSum = sum;
            }
        }
        Console.WriteLine("max sum = {0}",maxSum);
    }
}
