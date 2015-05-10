/*
Write a program to find the longest area of equal elements in array of strings.
You first should read an integer n and n strings (each at a separate line),
then find and print the longest sequence of equal elements (first its length,
then its elements). If multiple sequences have the same maximal length,
print the leftmost of them. Examples:
 
Input	Output
6			3
hi			ok
hi			ok
hello		ok
ok
ok
ok

2			1
SoftUni		SoftUni
Hello

4			4
hi			hi
hi			hi
hi			hi
hi			hi

5			2
wow			hi
hi			hi
hi
ok
ok
*/
using System;
using System.Collections.Generic;

class LongestAreaInArray {
	class sequence {
		public string str;
		public int count;

		public sequence() {
			str = "";
			count = 0;
		}

		public sequence( sequence other ) {
			str = other.str;
			count = other.count;
		}

		public void Print() {
			Console.WriteLine( "\n{0}", count );
			for ( int i = 0; i < count; ++i ) {
				Console.WriteLine( str );
			}
		}
	};

	static void Main( string[] args ) {
		int n = int.Parse( Console.ReadLine() );
		if ( n > 0 ) {
			List<sequence> arr = new List<sequence>();

			sequence last = new sequence(), temp = new sequence();
			for ( int i = 0; i < n; ++i ) {
				temp.str = Console.ReadLine();

				if ( last.str == temp.str ) {
					++last.count;
				} else {
					if ( last.str == "" ) {
						last.str = temp.str;
					} else {
						arr.Add( new sequence( last ) );
						last.str = temp.str;
					}
					last.count = 1;
				}

				temp.count = 1;
			}
			if ( last.str == temp.str ) {
				if ( last.str != "" ) {
					arr.Add( new sequence( last ) );
				} else {
					arr.Add( new sequence( temp ) );
				}
			}

			int index = 0, maxCount = 0;
			for ( int i = 0; i < arr.Count; ++i ) {
				if ( arr[ i ].count > maxCount ) {
					maxCount = arr[ i ].count;
					index = i;
				}
			}

			arr[ index ].Print();
		} else {
			Console.WriteLine( "invalid n" );
		}
	}
}