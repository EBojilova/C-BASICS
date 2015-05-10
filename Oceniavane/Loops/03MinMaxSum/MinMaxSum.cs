using System;
class MinMaxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        double avg = (double)sum / n;
        Console.WriteLine("min = " + minValue);
        Console.WriteLine("max = " + maxValue);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:0.00} ", avg);


    }
}