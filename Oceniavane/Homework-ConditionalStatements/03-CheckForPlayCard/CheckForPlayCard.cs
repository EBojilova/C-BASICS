using System;

    class CheckForPlayCard
    {
        static void Main()
        {
            string cardSign = Console.ReadLine();
            int cardNum;
            char cardChar;
            if (int.TryParse(cardSign, out cardNum))
            {
                if (cardNum >= 2 && cardNum <= 10)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else if(char.TryParse(cardSign, out cardChar)) 
            {
                if(cardChar == 'J' || cardChar == 'Q' || cardChar == 'K' || cardChar == 'A') 
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }

            }
          }
      }
    

