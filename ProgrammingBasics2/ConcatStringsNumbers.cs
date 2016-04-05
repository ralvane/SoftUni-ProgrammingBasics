using System;

namespace ConcatStringsNumbers {
	class Program {
		public static int Main(string[] args)
		{
			var firstName = Console.ReadLine ();
			var lastName = Console.ReadLine ();
			var age = int.Parse (Console.ReadLine ());
			var town = Console.ReadLine ();

			Console.WriteLine ("You are {0} {1}, " +
				"a {3:D}-years old person from {2}.", firstName, lastName, town, age);
			
			return 0;
		}
	}
}