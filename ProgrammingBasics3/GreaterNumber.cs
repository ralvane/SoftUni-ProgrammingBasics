using System;

namespace GreaterNumber {
	class Program {
		public static int Main( string[] args )
		{
			int a = int.Parse (Console.ReadLine ());
			int b = int.Parse (Console.ReadLine ());

			Console.WriteLine (a > b ? a : b);

			return 0;
		}
	}
}