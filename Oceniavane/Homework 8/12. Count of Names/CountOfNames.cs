/*
Write a program that reads a list of names and prints for each name how many times
it appears in the list. The names should be listed in alphabetical order.
Use the input and output format from the examples below. Examples:

Input								Output
Peter Steve Nakov Steve Alex Nakov	Alex -> 1
									Nakov -> 2
									Peter -> 1
									Steve -> 2

Nakov Nakov Nakov SoftUni Nakov		SoftUni -> 1
									Nakov -> 4
*/
using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames {
	static void Main( string[] args ) {
		string[] input = Console.ReadLine().Split( ' ' );

		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach ( string name in input ) {
			if ( !dictionary.ContainsKey( name ) ) {
				dictionary[ name ] = 0;
			}
			dictionary[ name ] += 1;
		}

		List<string> sortedKeys = dictionary.Keys.ToList();
		sortedKeys.Sort();

		foreach ( string key in sortedKeys ) {
			Console.WriteLine( "{0} -> {1}", key, dictionary[ key ] );
		}
	}
}