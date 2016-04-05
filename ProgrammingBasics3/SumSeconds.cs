using System;

namespace SumSeconds {
	class Program {
		public static int Main(string[] args)
		{
			int secs = int.Parse (Console.ReadLine ());
			secs += int.Parse (Console.ReadLine ());
			secs += int.Parse (Console.ReadLine ());

			Console.WriteLine ("{0}:{1:D2}", secs / 60, secs % 60);

			return 0;
		}
	}
}