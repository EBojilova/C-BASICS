using System;

class OddAndEvenJumps
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine().Replace(" ", "").Trim().ToLower();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        ulong resultOdd = 0;
        ulong resultEven = 0;
        for (int i = 1, counterOdd=0,counterEven=0; i <= word.Length; i++)
        {
            if (i%2==1)
            {
                counterOdd++;
                if (counterOdd%oddJump==0)
                {
                    resultOdd *= word[i - 1];
                }
                else
                {
                    resultOdd += word[i - 1];
                }
            }
            else if (i%2==0)
            {
                counterEven++;
                if (counterEven % evenJump == 0)
                {
                    resultEven *= word[i - 1];
                }
                else
                {
                    resultEven += word[i - 1];
                }
            }
        }
        Console.WriteLine("Odd: {0:X}", resultOdd);
        Console.WriteLine("Even: {0:X}", resultEven);
    }
}
    