using System;

namespace USDtoBGN {
	class Program {
		private static decimal rate = 1.79549m;

		public static int Main( string[] args )
		{
			var usd = decimal.Parse (Console.ReadLine ());
			decimal bgn = usd * rate;
			Console.WriteLine (Math.Round(bgn, 2) + " BGN");

			return 0;
		}
	}
}