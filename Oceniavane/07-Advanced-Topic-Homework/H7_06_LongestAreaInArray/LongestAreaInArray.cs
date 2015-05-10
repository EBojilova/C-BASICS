using System;

class LongestAreaInArray
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        int counter = 0;
        int maxRep = 0;
        string str = "";

        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
            if (i == 0)
            {
                str = arr[i];
                ++counter;
                maxRep = counter;
            }
            else {
                if (arr[i].Equals(arr[i - 1]))
                {
                    ++counter;
                    if (maxRep < counter) {
                        maxRep = counter;
                        str = arr[i];
                    }
                }
                else {
                    counter = 1;
                }
            }
        }

        Console.WriteLine(maxRep);
        Console.WriteLine(str);

    }
}