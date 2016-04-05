using System;
using System.Collections.Generic;

namespace SmallShop {
	class Program {

		public static int Main( string[] args )
		{
			Dictionary<string, double> sofia = new Dictionary<string, double>();
			sofia.Add ("coffee", 0.5);
			sofia.Add ("water", 0.8);
			sofia.Add ("beer", 1.2);
			sofia.Add ("sweets", 1.45);
			sofia.Add ("peanuts", 1.6);

			Dictionary<string, double> plovdiv = new Dictionary<string, double>();
			plovdiv.Add ("coffee", 0.4);
			plovdiv.Add ("water", 0.7);
			plovdiv.Add ("beer", 1.15);
			plovdiv.Add ("sweets", 1.3);
			plovdiv.Add ("peanuts", 1.5);

			Dictionary<string, double> varna = new Dictionary<string, double>();
			varna.Add ("coffee", 0.45);
			varna.Add ("water", 0.7);
			varna.Add ("beer", 1.1);
			varna.Add ("sweets", 1.35);
			varna.Add ("peanuts", 1.55);

			var item = Console.ReadLine ().ToLower();
			var city = Console.ReadLine ().ToLower();
			double count = double.Parse (Console.ReadLine ());

			if (city == "sofia") {
				if ( sofia.ContainsKey(item) )
					Console.WriteLine ("{0}", sofia[item] * count);
				else
					Console.WriteLine ("Invalid item");
			}

			else if (city == "plovdiv") {
				if ( plovdiv.ContainsKey(item) )
					Console.WriteLine ("{0}", plovdiv[item] * count);
				else
					Console.WriteLine ("Invalid item");
			}

			else if (city == "varna") {
				if ( varna.ContainsKey(item) )
					Console.WriteLine ("{0}", varna[item] * count);
				else
					Console.WriteLine ("Invalid item");
			}
			else
				Console.WriteLine ("Invalid city and/ or item");


			return 0;
		}
	}
}