using System;

namespace PersonalTitles {
	class Program {
		public static int Main(string[] args)
		{
			var	age = double.Parse (Console.ReadLine ());
			var gender = Console.ReadLine();

			if (age > 0 && age < 16) {
				if (gender.ToLower() == "f")
					Console.WriteLine ("Miss");
				else
					Console.WriteLine ("Master");
			}
			else {
				if (gender.ToLower() == "f")
					Console.WriteLine ("Ms.");
				else
					Console.WriteLine ("Mr.");
			}

			return 0;
		}
	}
}