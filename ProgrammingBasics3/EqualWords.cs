using System;

namespace EqualWords {
	class Program {
		public static int Main(string[] args)
		{
			var word1 = Console.ReadLine ();
			var word2 = Console.ReadLine ();

			if ( word1.ToLower() == word2.ToLower() )
				Console.WriteLine ("yes");
			else
				Console.WriteLine ("no");

			return 0;
		}
	}
}