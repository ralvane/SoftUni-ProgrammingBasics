namespace _03_CircleAreaPrecision12
{
	using System;

	class Program
	{
		public static void Main()
		{
			double r = double.Parse (Console.ReadLine ());

			double circleArea = Math.PI * r * r;

			Console.WriteLine ($"{circleArea:f12}");
		}
	}
}