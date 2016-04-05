using System;

namespace OddOrEven {
	class Program {
		public static int Main(string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			if ( n % 2 == 0 )
				Console.WriteLine ("even");
			else
				Console.WriteLine ("odd");

			return 0;
		}
	}
}