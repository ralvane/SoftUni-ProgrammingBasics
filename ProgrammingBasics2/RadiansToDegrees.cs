using System;

namespace RadiansToDegrees {
	class Program {
		public static int Main( string[] args )
		{
			var rads = decimal.Parse (Console.ReadLine ());
			decimal degs = rads * (decimal)(180 / Math.PI);
			Console.WriteLine (Math.Round(degs, 0));

			return 0;
		}
	}
}