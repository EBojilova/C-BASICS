using System;

namespace PrintSequence
{
	class PrintSequence
	{
		public static void Main (string[] args)
		{
			for (int i = 2; i < 12; i++) 
			{
				if (i % 2 == 1) 
				{
					Console.WriteLine (-i);
				} 
				else
				{
					Console.WriteLine (i);
				}
			}
		}
	}
}
