using System;

namespace Circle {
	class Program {
		public static int Main(string[] args)
		{
			var r = double.Parse (Console.ReadLine());

			double area		= Math.PI * Math.Pow (r, 2);
			double perimeter = 2 * Math.PI * r;

			Console.WriteLine ("Area = {0}\nPerimeter = {1}", area, perimeter);

			return 0;
		}
	}
}