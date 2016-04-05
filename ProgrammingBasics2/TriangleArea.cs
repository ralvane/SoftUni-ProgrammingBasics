using System;

namespace TriangleArea {
	class Program {
		public static int Main(string[] args)
		{
			var a = decimal.Parse (Console.ReadLine ());
			var b = decimal.Parse (Console.ReadLine ());

			decimal area = a * b / 2;
			Console.WriteLine ("Area: {0}", Math.Round(area, 2));

			return 0;
		}
	}
}