using System;
using System.Collections.Generic;
using System.Linq;
class LoadTimeCalc
{
	static Dictionary<string, List<double>> d = new Dictionary<string, List<double>>();
	static List<string> URLs = new List<string>();
	
	static void Main()
	{
		string input = "";
		

		while (input != "end")
		{
			input = Console.ReadLine();

			if (input == "end")
			{
				break;
			}

			string ReadURL = input.Split(' ')[2];
			double ReadTime = double.Parse(input.Split(' ')[3]);

			addOrUpdate(ReadURL, ReadTime);
		}

		List<string> keyList = new List<string>(d.Keys);

		foreach (var item in d)
		{

			int count = URLs.Count();
			Console.WriteLine(item + " " + count);
		}

	}
	static void addOrUpdate(string key, double[] newValue)
	{
		double val;

		if (d.TryGetValue(key, out val[1]))
		{
			d[key].Add = val + newValue;
		}
		else
		{
			d.Add(key, newValue);
		}
	}
}

//it doesn't work