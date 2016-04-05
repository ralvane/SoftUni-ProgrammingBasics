using System;

namespace Time_15Minutes {
	class Program {
		public static int Main(string[] args)
		{
			int current_hour = int.Parse (Console.ReadLine ());
			int current_min	= int.Parse (Console.ReadLine ());

			current_min += 15;
			if (current_min > 59) {
				current_hour++;
				current_min -= 60;
			}

			if (current_hour > 23)
				current_hour -= 24;

			Console.WriteLine ("{0}:{1:D2}", current_hour, current_min);

			return 0;
		}
	}
}