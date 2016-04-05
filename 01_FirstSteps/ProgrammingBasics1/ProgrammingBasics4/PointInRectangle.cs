using System;

namespace PointInRectangle {
	class Program {
		public static int Main( string[] args )
		{
			double x1 = double.Parse (Console.ReadLine ());
			double y1 = double.Parse (Console.ReadLine ());
			double x2 = double.Parse (Console.ReadLine ());
			double y2 = double.Parse (Console.ReadLine ());
			double x = double.Parse (Console.ReadLine ());
			double y = double.Parse (Console.ReadLine ());

			var inside = (x >= x1 && x <= x2) && (y >= y1 && y <= y2);
			if (inside)
				Console.WriteLine ("inside");
			else
				Console.WriteLine ("outside");

			return 0;
		}
	}
}