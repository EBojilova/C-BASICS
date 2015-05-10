using System;

class SortingNums
{
    static void swap(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;
    }

    static int Partition(int[] arr, int start, int end) {
        int pivot = arr[end - 1];
        int pIndex = start;

        for (int i = start; i < end - 1; i++)
        {
            if (arr[i] <= pivot) {
                swap(ref arr[i], ref arr[pIndex]);
                ++pIndex;
            }   
        }
        swap(ref arr[end - 1], ref arr[pIndex]);

        return pIndex;
    }

    static void QuickSort(int[] arr, int start, int end) {
        if (start >= end - 1)
        {
            return;
        }

        int pivotIndex = Partition(arr, start, end);
        QuickSort(arr, start, pivotIndex);
        QuickSort(arr, pivotIndex + 1, end);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        QuickSort(arr, 0, arr.Length);
        Console.WriteLine("Sorted...");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}