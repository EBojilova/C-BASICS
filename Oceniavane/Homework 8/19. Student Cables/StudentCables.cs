using System;
using System.Collections.Generic;

class StudentCables {
	static void Main( string[] args ) {
		int n = int.Parse( Console.ReadLine() ),
			cableLength, totalCableLength = 0, cableCount = 0;

		for ( int i = 0; i < n; ++i ) {
			cableLength = int.Parse( Console.ReadLine() );

			if ( Console.ReadLine() == "meters" ) {
				cableLength *= 100;
			}

			if ( cableLength >= 20 ) {
				totalCableLength += cableLength;
				++cableCount;
			}
		}
		totalCableLength -= 3 * ( cableCount - 1 );

		cableCount = totalCableLength / 504;
		int cableRemainder = totalCableLength % 504;
		Console.WriteLine( "{0}\n{1}", cableCount, cableRemainder );
	}
}