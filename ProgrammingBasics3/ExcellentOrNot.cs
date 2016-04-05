using System;

namespace ExcellentResult {
	class Program {
		public static int Main( string[] args )
		{
			var grade = double.Parse (Console.ReadLine ());

			if ( grade >= 5.5 )
				Console.WriteLine ("Excellent!");
			else
				Console.WriteLine ("Not excellent.");

			return 0;
		}
	}
}