/*
Write a program that enters two dates in format dd.MM.yyyy
and returns the number of days between them. Examples:

First date
Second date		Days between

17.03.2014
30.04.2014		44

17.03.2014
17.03.2014		0

14.06.1980
5.03.2014		12317

5.03.2014
3.03.2014		-2
*/
using System;
using System.Globalization;

class DifferenceBetweenDates {
	static int DaysBetween( DateTime firstDate, DateTime secondDate ) {
		TimeSpan difference = secondDate - firstDate;
		return difference.Days;
	}

	static void Main( string[] args ) {
		string format = "d.MM.yyyy";
		DateTime firstDate, secondDate;

		Console.WriteLine( "enter first date in format {0}", format );
		firstDate = DateTime.ParseExact( Console.ReadLine(), format, null );
		Console.WriteLine( "enter second date in format {0}", format );
		secondDate = DateTime.ParseExact( Console.ReadLine(), format, null );

		Console.WriteLine( "\nnumber of days between\n {0}\nand\n {1}\nis {2}",
			firstDate.ToString( format ), secondDate.ToString( format ), DaysBetween( firstDate, secondDate ) );
	}
}