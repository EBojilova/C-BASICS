/*
Write a program that reads a number n and a sequence of n integers, sorts them and prints them. Examples:

Input	Output
5		-3
3		0
-3		2
2		3
122		122
0

3		0
0		0
1		1
0	 
*/
using System;
using System.Collections.Generic;

class SortingNumbers {
	static void Main( string[] args ) {
		List<int> numbers = new List<int>();

		int n = int.Parse( Console.ReadLine() );
		for ( int i = 0; i < n; ++i ) {
			numbers.Add( int.Parse( Console.ReadLine() ) );
		}

		numbers.Sort();
		Console.WriteLine();
		foreach ( int number in numbers ) {
			Console.WriteLine( number );
		}
	}
}