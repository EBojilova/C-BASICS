using System;
using System.Collections.Generic;
using System.Linq;

    class KnightPath
    {
        static void Main(string[] args)
        {
            byte[] matrix = new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 };
            string inputLine;
            byte row = 0;
            byte col = 0;
            byte rowNew=0;
            byte colNew=0;
            while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "stop"))
            {
                //"left up", "left down", "right up", "right down", "up left", "up right", "down left", "down right"
                if (inputLine == "left up")
                {
                    rowNew =(byte)(row - 1);
                    colNew = (byte)(col + 2);
                }
                else if (inputLine == "left down")
                {
                    rowNew = (byte)(row + 1);
                    colNew = (byte)(col + 2);
                }
                else if (inputLine == "right up")
                {
                    rowNew = (byte)(row - 1);
                    colNew = (byte)(col - 2);
                }
                else if (inputLine == "right down")
                {
                    rowNew = (byte)(row + 1);
                    colNew = (byte)(col - 2);
                }
                else if (inputLine == "up right")
                {
                    rowNew = (byte)(row - 2);
                    colNew = (byte)(col - 1);
                }
                else if (inputLine == "up left")
                {
                    rowNew = (byte)(row - 2);
                    colNew = (byte)(col + 1);
                }
                else if (inputLine == "down right")
                {
                    rowNew = (byte)(row + 2);
                    colNew = (byte)(col - 1);
                }
                else if (inputLine == "down left")
                {
                    rowNew = (byte)(row + 2);
                    colNew = (byte)(col + 1);
                }
                if (rowNew>=0 && rowNew<8 && colNew>=0 && colNew<8)
                {
                    row = rowNew;
                    col = colNew;
                    matrix[row] ^= (byte)(1 << col);
                }
                
            }
            if (matrix.All(x => x == 0))
            {
                Console.WriteLine("[Board is empty]");
            }
            for (int i = 0; i < 8; i++)
            {
                if (matrix[i] !=0)
                {
                    Console.WriteLine(matrix[i]); 
                }
                //Console.WriteLine(Convert.ToString(matrix[i], 2).PadLeft(8, '0'));
            }
        }
    }

