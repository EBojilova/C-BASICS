/*
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

Input	Output
3 6		aaa aba aca	ada aea afa
		bbb bcb bdb	beb bfb bgb
		ccc cec cdc	cfc cgc chc

2 3		aaa aba aca
		bbb bcb bdb

1 1		aaa

1 3		aaa aba aca
*/
using System;

class MatrixOfPalindromes {
	static void Main( string[] args ) {
		int r = int.Parse( Console.ReadLine() ),
			c = int.Parse( Console.ReadLine() );

		string matrix = "";

		for ( int m = 0; m < r; ++m ) {
			for ( int n = 0; n < c; ++n ) {
				matrix += "" + (char)( 'a' + m ) + (char)( 'a' + n + m ) + (char)( 'a' + m ) + " ";
			}
			matrix += '\n';
		}

		Console.Write( matrix );
	}
}