using System;

namespace SpeedInfo {
	class Program {
		public static int Main(string[] args)
		{
			decimal speed = decimal.Parse (Console.ReadLine ());

			if (speed <= 10m)
				Console.WriteLine ("slow");
			else if (speed <= 50m)
				Console.WriteLine ("average");
			else if (speed <= 150m)
				Console.WriteLine ("fast");
			else if (speed <= 1000)
				Console.WriteLine ("ultra fast");
			else
				Console.WriteLine ("extremely fast");

			return 0;
		}
	}
}