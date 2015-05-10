using System;
class OddEven

{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        int[] array = new int[stringArray.Length];
        int oddSum = 1;
        int evenSum = 1;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(stringArray[i]);
            if ((i + 1) % 2 == 0)
            {
                evenSum *= array[i];
            }
            else
            {
                oddSum *= array[i];
            }
        }
        if (oddSum == evenSum)
        {
            Console.WriteLine("yes\nproduct = {0}", oddSum);
        }
        else
        {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddSum, evenSum);
        }

    }
}