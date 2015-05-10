using System;

class InsideTheBuilding {
	static void Main( string[] args ) {
		short h = short.Parse( Console.ReadLine() ),
			x, y;
		string[] output = new string[ 5 ];

		for ( int i = 0; i < output.Length; ++i ) {
			x = short.Parse( Console.ReadLine() );
			y = short.Parse( Console.ReadLine() );

			if ( ( x >= 0 && x <= 3 * h && y >= 0 && y <= h )
			|| ( x >= h && x <= 2 * h && y >= h && y <= 4 * h ) ) {
				output[ i ] = "inside";
			} else {
				output[ i ] = "outside";
			}
		}

		foreach ( string result in output ) {
			Console.WriteLine( result );
		}
	}
}