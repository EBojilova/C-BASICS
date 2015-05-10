using System;

class OddEvenCounter
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        string oddEven = Console.ReadLine();
        int count;
        int setN=0;
        int maxCount = 0;
        for (int i = 0; i < n; i++)
        {
            count = 0;
            for (int j = 0; j < c; j++)
            {
                int number=int.Parse(Console.ReadLine());
                if (number%2==0 && oddEven=="even" )
                {
                    count++;
                }
                if (number%2==1 && oddEven=="odd")
                {
                    count++;
                }
            }
            if (count>maxCount)
            {
                maxCount = count;
                setN = i;
            }
        }
        string[] words = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
        if (maxCount > 0)
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", words[setN], oddEven, maxCount); 
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
