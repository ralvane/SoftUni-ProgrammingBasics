using System;

namespace GuessPassword {
	class Program {
		public static int Main(string[] args)
		{
			var PASS = "s3cr3t!P@ssw0rd";

			var userPass = Console.ReadLine ();

			if ( PASS == userPass )
				Console.WriteLine ("Welcome");
			else
				Console.WriteLine ("Wrong password!");

			return 0;
		}
	}
}