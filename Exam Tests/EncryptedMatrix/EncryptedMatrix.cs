using System;

class EncryptedMatrix
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        int row, col = new int();
       
        int current;
        string encryptedMessage = "";
        for (int i = 0; i < message.Length; i++)
        {
            current = message[i] % 10;
            if (current == 0 || current % 2 == 0)
            {
                current *= current;
            }
            else if ((current % 2 == 1) && message.Length>1)
            {
                if (i == 0)
                {
                    current += (message[i + 1] % 10);
                }
                else if (i == message.Length - 1)
                {
                    current += (message[i - 1] % 10);
                }
                else
                {
                    current += ((message[i - 1] % 10)+(message[i + 1] % 10));
                }
            }
            encryptedMessage += current.ToString();
        }
        int[,] matrix = new int[encryptedMessage.Length, encryptedMessage.Length];
        char diagonal = char.Parse(Console.ReadLine());
        if (diagonal=='\\')
        {
            for (row = 0; row < encryptedMessage.Length; row++)
        {
            //LEFT-DIAGONAL
            matrix[row, row] = encryptedMessage[row]-48;
        }
        }
        else if (diagonal == '/')
        {
            int count; ;
            for (row = encryptedMessage.Length - 1, count=0; row >= 0; row--, count++)
            {
                //RIGHT-DIAGONAL
                matrix[row, encryptedMessage.Length - 1 - row] = encryptedMessage[count]-48;
            }
        }
        for (row = 0; row < encryptedMessage.Length ; row++)
        {
            for (col = 0; col < encryptedMessage.Length; col++)
            {
                Console.Write("{0} ", matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}
