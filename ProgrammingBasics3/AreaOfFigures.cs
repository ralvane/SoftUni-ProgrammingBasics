using System;

namespace AreaOfFigures {
	class Program {
		public static int Main()
		{
			var figure = Console.ReadLine ().ToLower();

			if (figure == "square") {
				decimal side = decimal.Parse (Console.ReadLine ());
				Console.WriteLine ("{0:F3}", side * side);
			} else if (figure == "rectangle") {
				var side1 = decimal.Parse (Console.ReadLine ());
				var side2 = decimal.Parse (Console.ReadLine ());
				Console.WriteLine ("{0:F3}", side1 * side2);
			} else if (figure == "circle") {
				var r = decimal.Parse (Console.ReadLine ());
				Console.WriteLine ("{0:F3}", r * r * (decimal)Math.PI);
			} else if (figure == "triangle") {
				var side1 = decimal.Parse (Console.ReadLine ());
				var side2 = decimal.Parse (Console.ReadLine ());
				Console.WriteLine ("{0:F3}", side1 * side2 / 2);
			}

			return 0;
		}
	}
}