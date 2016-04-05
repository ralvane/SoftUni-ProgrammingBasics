using System;

namespace GreetingByName {
	class Program {
		public static int Main (string[] args)
		{
			//Console.Write ("Name: ");
			var name = Console.ReadLine ();
			Console.WriteLine ("Hello, {0}!", name);
			
			return 0;
		}
	}
}