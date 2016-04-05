using System;

namespace ThreeEqualNumbers {
	class Program {
		public static int Main(string[] args)
		{
			decimal n1 = decimal.Parse (Console.ReadLine ());
			decimal n2 = decimal.Parse (Console.ReadLine ());
			decimal n3 = decimal.Parse (Console.ReadLine ());

			if ( n1 == n2 && n1 == n3 )
				Console.WriteLine ("yes");
			else
				Console.WriteLine ("no");
			
			return 0;
		}
	}
}