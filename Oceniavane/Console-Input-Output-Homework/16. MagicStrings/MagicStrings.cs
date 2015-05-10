using System;

class MagicStrings
{

    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        char[] number = { 'k', 's', 'p', 'n' };
        int count = 0;


        for (int n1 = 0; n1 < number.Length; n1++)
        {
            for (int n2 = 0; n2 < number.Length; n2++)
            {
                for (int n3 = 0; n3 < number.Length; n3++)
                {
                    for (int n4 = 0; n4 < number.Length; n4++)
                    {
                        string leftLetters = "" + number[n4] + number[n3] + number[n2] + number[n1];       
                        int sumLeft = CalcSum(leftLetters);                                                
                        for (int n5 = 0; n5 < number.Length; n5++)  
                        {
                            for (int n6 = 0; n6 < number.Length; n6++)
                            {
                                for (int n7 = 0; n7 < number.Length; n7++)
                                {
                                    for (int n8 = 0; n8 < number.Length; n8++)
                                    {
                                        string rightLetters = "" + number[n8] + number[n7] + number[n6] + number[n5];
                                        int sumRight = CalcSum(rightLetters);                                          
                                        if (Math.Abs(sumLeft - sumRight) == input)
                                        {
                                            Console.WriteLine(leftLetters + rightLetters);
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }


    static int CalcSum(string str)          
    {
        int sum = 0;

        foreach (var letter in str)
        {
            switch (letter)
            {
                case 'k': sum += 1; break;
                case 'p': sum += 5; break;
                case 'n': sum += 4; break;
                case 's': sum += 3; break;
                default:
                    break;
            }
        }

        return sum;
    }
}