using System;

class SpyHard
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        string word = Console.ReadLine();
        word = word.ToUpper();
        int sum = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if ((word[i] > 64) && (word[i] < 91))
            {
                sum += word[i] - 64;
            }
            else
            {
                sum += word[i];
            }
        }
        string stringKey = "";
        int devision;
        while (sum >= 1)
        {
            devision = sum / key;
            stringKey = (sum % key) + stringKey;
            sum = devision;
        }
        Console.WriteLine("{0}{1}{2}", key, word.Length, stringKey);
    }
}
