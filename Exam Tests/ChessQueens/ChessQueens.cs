using System;

class ChessQeens
{
    static void Main()
    {
        //Have to rework it because it is not accepted methods to write on the console.
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int row = 'a'; row < 'a'+ n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                int upLeft = FindQeensPositions(counter, n, row, col, -(d + 1), -(d + 1));
                int strUp = FindQeensPositions(counter, n, row, col, 0, -(d + 1));
                int upRight = FindQeensPositions(counter, n, row, col, +(d + 1), -(d + 1));
                int strLeft = FindQeensPositions(counter,n, row, col, -(d+1), 0);
                int strRight = FindQeensPositions(counter,n, row, col, +(d+1), 0);
                int downLeft = FindQeensPositions(counter, n, row, col, -(d + 1), +(d + 1));
                int strDown = FindQeensPositions(counter,n, row, col, 0, +(d+1));
                int downRight = FindQeensPositions(counter, n, row, col, +(d + 1), +(d + 1));
                counter += (strLeft + strRight + strUp + strDown+upLeft+upRight+downLeft+downRight);
            }
        }
        if (counter==0)
        {
            Console.WriteLine("No valid positions");
        }
    }

    private static int FindQeensPositions(int counter, int n, int row, int col, int directionX, int directionY)
    {
        int col2 = col + directionX;
        int row2 = row + directionY;
        if (row2 >= 'a' && row2 < 'a'+n && col2 >= 1 && col2 <= n)
        {
            Console.WriteLine("{0}{1} - {2}{3}", (char)row, col, (char)row2, col2);
            counter++;
        }
        return counter;
    }
}
