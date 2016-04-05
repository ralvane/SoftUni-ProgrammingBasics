using System;

namespace FruitShop {
	class Program {
		public static int Main( string[] args )
		{
			var fruit = Console.ReadLine ().ToLower();
			var wDay = Console.ReadLine().ToLower();
			double quantity = double.Parse (Console.ReadLine ());

			var workDay = wDay == "monday" || wDay == "tuesday" || wDay == "wednesday" ||
			              wDay == "thursday" || wDay == "friday";
			var holiday = wDay == "saturday" || wDay == "sunday";
			double value = 1;

			if (workDay && !holiday) {
				if (fruit == "banana")
					value *= quantity * 2.5;
				else if (fruit == "apple")
					value *= quantity * 1.2;
				else if (fruit == "orange")
					value *= quantity * 0.85;
				else if (fruit == "grapefruit")
					value *= quantity * 1.45;
				else if (fruit == "kiwi")
					value *= quantity * 2.7;
				else if (fruit == "pineapple")
					value *= quantity * 5.5;
				else if (fruit == "grapes")
					value *= quantity * 3.85;
				else {
					Console.WriteLine ("error");
					return (1);
				}
			} else if (!workDay && holiday) {
				if (fruit == "banana")
					value *= quantity * 2.7;
				else if (fruit == "apple")
					value *= quantity * 1.25;
				else if (fruit == "orange")
					value *= quantity * 0.9;
				else if (fruit == "grapefruit")
					value *= quantity * 1.6;
				else if (fruit == "kiwi")
					value *= quantity * 3;
				else if (fruit == "pineapple")
					value *= quantity * 5.6;
				else if (fruit == "grapes")
					value *= quantity * 4.2;
				else {
					Console.WriteLine ("error");
					return (1);
				}
			} else {
				Console.WriteLine ("error");
				return (1);
			}

			Console.WriteLine ("{0:F2}", value);

			return 0;
		}
	}
}