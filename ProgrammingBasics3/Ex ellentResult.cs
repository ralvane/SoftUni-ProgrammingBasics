using System;

namespace ExcellentResult {
	class Program {
		public static int Main( string[] args )
		{
			var grade = double.Parse (Console.ReadLine ());

			if ( grade >= 5.5 )
				Console.WriteLine ("Excellent!");

			return 0;
		}
	}
}