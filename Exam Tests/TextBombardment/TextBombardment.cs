using System;

class TextBombardment
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int width = int.Parse(Console.ReadLine());
        int height = text.Length / width;
        height += text.Length % width != 0 ? 1 : 0;
        char[,] matrix = new char[height, width];
        int n = 0;
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (n<text.Length)
                {
                    matrix[row, col] = text[n];
                    n++; 
                }
                //Console.Write("{0} ", matrix[row, col]);
            }
            //Console.WriteLine();
        }
        string[] bombCol = (Console.ReadLine()).Split(' ');
        for (int i = 0; i < bombCol.Length; i++)
        {
            int bombShoots = 0;
            int col = int.Parse(bombCol[i]);
            for (int j = 0; j < height; j++)
            {
                if (matrix[j,col] !=' ')
                {
                    matrix[j, col] = ' ';
                    bombShoots++;
                }
                else if ((matrix[j,col] ==' ') && bombShoots>0)
                {
                    break;
                }
            }
        }
        foreach (char letter in matrix)
        {
            if (letter !='\0')
            {
                Console.Write(letter);
            }
        }
    }
}
