using System;
class LongestArea
{
	static void Main()
	{
		Console.WriteLine("Please input how many strings you are going to input.");
		int count = int.Parse(Console.ReadLine());
		string laststr = "", longeststr = "";
		int longestSeq = 1, currentSeq = 0;

		string[] strings = new string[count];

		Console.WriteLine("Please enter " + count + " strings.");
		for (int i = 0; i < count; i++)
		{
			strings[i] = Console.ReadLine();
			if (laststr == strings[i])
			{
				currentSeq++;
				if (currentSeq > longestSeq)
				{
					longestSeq = currentSeq;
					longeststr = strings[i];
				}
			}
			else
			{
				currentSeq = 1;
			}
			laststr = strings[i];

		}

		Console.WriteLine(longestSeq);

		for (int i = 1; i <= longestSeq; i++)
		{
			Console.WriteLine(longeststr);
		}
	}
}