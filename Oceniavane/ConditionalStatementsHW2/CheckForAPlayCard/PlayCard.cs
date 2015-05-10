
/*Problem 3.	Check for a Play Card
Classical play cards use the following signs to designate the card face:
2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a
string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
character	Valid card sign?
5	    yes
1	    no
Q	    yes
q	    no
P	    no
10	    yes
500	    no*/


using System;

class PlayCard
{
    static void Main()
    {
        Console.Write("Enter a character and press key enter, character: ");
        string character = Console.ReadLine();
        if (character == "2" || character == "3" || character == "4" ||
            character == "5" || character == "6" || character == "7" ||
            character == "8" || character == "9" || character == "10" ||
            character == "J" || character == "Q" || character == "K" ||
            character == "A")
        {
            Console.WriteLine("chartesr: {0}, Valid card: yes", character);
        }
        else
        {
            Console.WriteLine("chartesr: {0}, Valid card: no", character);
        }
    }
}




