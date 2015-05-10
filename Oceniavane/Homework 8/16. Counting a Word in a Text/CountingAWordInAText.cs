using System;
using System.IO;
using System.Text.RegularExpressions;

class CountingAWordInAText {
	static void Main( string[] args ) {
		int count = 0;
		string wordToFind = Console.ReadLine().Trim();
		Regex wordRegex = new Regex( @"\b" + wordToFind + @"+\b", RegexOptions.IgnoreCase );

		////////// da se vuvejdat pove4e ot 254 bukvi
		int bufferSize = 1024;
		Stream inStream = Console.OpenStandardInput( bufferSize );
		Console.SetIn( new StreamReader( inStream, Console.InputEncoding, false, bufferSize ) );
		//////////////////////////////////////////////
		string input = Console.ReadLine();

		MatchCollection matches = wordRegex.Matches( input );
		count = matches.Count;

		Console.WriteLine( count );
	}
}