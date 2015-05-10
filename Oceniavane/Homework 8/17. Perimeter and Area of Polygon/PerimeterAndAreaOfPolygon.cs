using System;
using System.Collections.Generic;
using System.Linq;

class PerimeterAndAreaOfPolygon {
	class point_t {
		public float x { get; set; }
		public float y { get; set; }

		public static point_t Parse( string str ) {
			string[] strToParse = str.Split( ' ' );
			point_t result = new point_t( float.Parse( strToParse[ 0 ] ), float.Parse( strToParse[ 1 ] ) );
			return result;
		}

		public point_t( float x, float y ) {
			this.x = x;
			this.y = y;
		}

		public double GetDistance( point_t other ) {
			return Math.Sqrt( ( x - other.x ) * ( x - other.x ) + ( y - other.y ) * ( y - other.y ) );
		}
	};

	class polygon_t {
		List<point_t> points = new List<point_t>();

		public void AddPoint( point_t point ) {
			points.Add( point );
		}

		public double GetPerimeter() {
			double perimeter = 0;

			if ( points.Count > 2 ) {
				for ( int i = 0; i < points.Count - 1; ++i ) {
					perimeter += points[ i ].GetDistance( points[ i + 1 ] );
				}
				perimeter += points[ 0 ].GetDistance( points[ points.Count - 1 ] );
			}

			return perimeter;
		}

		public double GetArea() {
			double area = 0.0;

			if ( points.Count > 2 ) {
				for ( int i = 0; i < points.Count - 1; ++i ) {
					area += points[ i ].x * points[ i + 1 ].y - points[ i + 1 ].x * points[ i ].y;
				}
				area = Math.Abs( area / 2 );
			}

			return area;
		}
	};

	static void Main( string[] args ) {
		polygon_t polygon = new polygon_t();

		int n = int.Parse( Console.ReadLine() );
		for ( int i = 0; i < n; ++i ) {
			polygon.AddPoint( point_t.Parse( Console.ReadLine() ) );
		}

		Console.WriteLine( "perimeter = {0:0.##}\narea = {1:0.##}", polygon.GetPerimeter(), polygon.GetArea() );
	}
}