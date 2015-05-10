/*
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
Examples:
 
	Input
The site nakov.com can be access from http://nakov.com
or www.nakov.com. It has subdomains like mail.nakov.com
and svetlin.nakov.com. Please check http://blog.nakov.com
for more information.

	Output
http://nakov.com
www.nakov.com
http://blog.nakov.com
*/
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractURLsFromText {
	static void Main( string[] args ) {
		List<string> urlList = new List<string>();
		Regex urlRegex = new Regex( @"(http://|www.)([a-zA-Z0-9])+(\.\w+)*", RegexOptions.IgnoreCase );

		string input = Console.ReadLine();
		MatchCollection matches = urlRegex.Matches( input );
		foreach ( Match match in matches ) {
			urlList.Add( match.Value );
		}

		foreach ( string url in urlList ) {
			Console.WriteLine( url );
		}
	}
}