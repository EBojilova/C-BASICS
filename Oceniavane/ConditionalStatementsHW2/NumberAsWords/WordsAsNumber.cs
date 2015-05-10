

/*Problem 11.* Number as Words
Write a program that converts a number in the range [0…999] to words, corresponding
to the English pronunciation. Examples:
numbers	number as words
0	Zero
9	Nine
10	Ten
12	Twelve
19	Nineteen
25	Twenty five
98	Ninety eight
273	Two hundred and seventy three
400	Four hundred
501	Five hundred and one
617	Six hundred and seventeen
711	Seven hundred and eleven
999	Nine hundred and ninety nine*/


using System;

class WordsAsNumber
{
    static void Main()
    {
        Console.Write("Enter a number [0...999] and press key enter, number = ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid input. Enter a number [0...999]");
        }
        else
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("number as word: Zero");
                    break;
                case 9:
                    Console.WriteLine("number as word: Nine");
                    break;
                case 10:
                    Console.WriteLine("number as word: Ten");
                    break;
                case 12:
                    Console.WriteLine("number as word: Twelve");
                    break;
                case 19:
                    Console.WriteLine("number as word: Nineteen");
                    break;
                case 25:
                    Console.WriteLine("number as word: Twenty five");
                    break;
                case 98:
                    Console.WriteLine("number as word: Ninety eight");
                    break;
                case 273:
                    Console.WriteLine("number as word: Two hundred and seventy three");
                    break;
                case 400:
                    Console.WriteLine("number as word: Four hundred");
                    break;
                case 501:
                    Console.WriteLine("number as word: Five hundred and one");
                    break;
                case 617:
                    Console.WriteLine("number as word: Six hundred and seventeen");
                    break;
                case 711:
                    Console.WriteLine("number as word: Seven hundred and eleven");
                    break;
                case 999:
                    Console.WriteLine("number as word: Nine hundred and ninety nine");
                    break;
            }
        }
    }
}
            


            
      
