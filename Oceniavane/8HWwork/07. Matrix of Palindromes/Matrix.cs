using System;

class Matrix
{
	static void Main()
	{
		int r = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		char[] alphabet = new char[26];


		for (int i = 0; i < 26; i++)
		{
			alphabet[i] = (char)('a' + i);
		}

		for (int i = 0; i < r; i++)
		{
			for (int j = i; j < c+i; j++)
			{
				Console.Write(alphabet[i]);
				Console.Write(alphabet[j]);
				Console.Write(alphabet[i] + " ");
			}
			Console.WriteLine();
		}
	}
}