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

			var onX = (x >= x1 && x <= x2) && (y == y1 || y == y2);
			var onY = (y >= y1 && y <= y2) && (x == x1 || x == x2);
			if (onX || onY)
				Console.WriteLine ("Border");
			else
				Console.WriteLine ("Inside / Outside");

			return 0;
		}
	}
}