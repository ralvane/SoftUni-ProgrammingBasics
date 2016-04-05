using System;

namespace TrapezoidArea {
	class Program {
		public static int Main(string[] args)
		{
			var b1	= decimal.Parse (Console.ReadLine ());
			var b2	= decimal.Parse (Console.ReadLine ());
			var h	= decimal.Parse (Console.ReadLine ());

			var area = (b1 + b2) * h / 2;
			Console.WriteLine ("{0}", area);

			return 0;
		}
	}
}