using System;

namespace MetricConverter {
	class Program {
		public static int Main(string[] args)
		{
			double distance = double.Parse (Console.ReadLine ());
			var metricSrc = Console.ReadLine ();
			var metricTarget = Console.ReadLine ();

			if (metricSrc == "mm")
				distance /= 1000;
			else if (metricSrc == "cm")
				distance /= 100;
			else if (metricSrc == "mi")
				distance /= 0.000621371192;
			else if (metricSrc == "in")
				distance /= 39.3700787;
			else if (metricSrc == "km")
				distance /= 0.001;
			else if (metricSrc == "ft")
				distance /= 3.2808399;
			else if (metricSrc == "yd")
				distance /= 1.0936133;

			if (metricTarget == "mm")
				distance *= 1000;
			else if (metricTarget == "cm")
				distance *= 100;
			else if (metricTarget == "mi")
				distance *= 0.000621371192;
			else if (metricTarget == "in")
				distance *= 39.3700787;
			else if (metricTarget == "km")
				distance *= 0.001;
			else if (metricTarget == "ft")
				distance *= 3.2808399;
			else if (metricTarget == "yd")
				distance *= 1.0936133;
			
			Console.WriteLine ("{0} {1}", distance, metricTarget);

			return 0;
		}
	}
}