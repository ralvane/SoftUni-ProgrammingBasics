using System;

namespace RectangleArea {
	class Program {
		public static int Main(string[] args)
		{
			double x1 = double.Parse (Console.ReadLine ());
			double y1 = double.Parse (Console.ReadLine ());
			double x2 = double.Parse (Console.ReadLine ());
			double y2 = double.Parse (Console.ReadLine ());

			double side1 = Math.Abs (x1 - x2);
			double side2 = Math.Abs (y1 - y2);

			Console.WriteLine ("{0}\n{1}", 
				side1 * side2, 2 * (side1 + side2));

			return 0;
		}
	}
}