using System;
using System.Collections.Generic;

class PrimesInRange
{
    static void swap(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;
    }

    static bool IsPrime(int n) {
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(n);

        while (divider <= maxDivider)
        {
            if (n % divider == 0)
                return false;
            ++divider;
        }

        return true;
    }

    static List<int> FindPrimesInRange(int startNum, int endNum){
        List<int> list = new List<int>();
        if (startNum > endNum) {
            swap(ref startNum, ref endNum);
        }

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i)) {
                list.Add(i);
            }
        }

        return list;
    }

    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        List<int> list = FindPrimesInRange(startNum, endNum);
        int count = 0;
        foreach (int n in list)
        {
            if (count == 0)
            {
                Console.Write(n);
            }
            else {
                Console.Write(", " + n);
            }
            ++count;
        }
        Console.WriteLine();
    }
}