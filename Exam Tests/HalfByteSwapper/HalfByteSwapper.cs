using System;

class HalfByteSwapper
{
    static void Main(string[] args)
    {
        uint[] matrix = new uint[4];
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = uint.Parse(Console.ReadLine());
        }
        string inputLine;
        while (!(string.IsNullOrEmpty(inputLine = Console.ReadLine()) || inputLine == "End"))
        {
            string[] input1 = inputLine.Split(' ');
            int shootRow1 = int.Parse(input1[0]);
            int shoot4Group1 = int.Parse(input1[1])*4;
            uint mask1 = matrix[shootRow1] & (15u << shoot4Group1);
            matrix[shootRow1] ^= mask1;
            string[] input2 = Console.ReadLine().Split(' ');
            int shootRow2 = int.Parse(input2[0]);
            int shoot4Group2 = int.Parse(input2[1])*4;
            uint mask2 = matrix[shootRow2] & (15u << shoot4Group2);
            matrix[shootRow2] ^= mask2;
            mask1 >>= shoot4Group1;
            mask2 >>= shoot4Group2;
            matrix[shootRow1] |= mask2 << shoot4Group1;
            matrix[shootRow2] |= mask1 << shoot4Group2;
        }
        foreach (uint num in matrix)
        {
            Console.WriteLine(num);
        }
    }
}
