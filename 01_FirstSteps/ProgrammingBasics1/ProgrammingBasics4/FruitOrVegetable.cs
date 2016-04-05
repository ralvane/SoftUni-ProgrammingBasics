using System;
using System.Collections.Generic;

namespace FruitOrVegetable {
	class Program {
		public static int Main( string[] args )
		{
			var item = Console.ReadLine ().ToLower();

			List<string> fruits = new List<string> ();
			fruits.Add ("banana");
			fruits.Add ("apple");
			fruits.Add ("kiwi");
			fruits.Add ("cherry");
			fruits.Add ("lemon");
			fruits.Add ("grapes");

			List<string> vegetables = new List<string> ();
			vegetables.Add ("tomato");
			vegetables.Add ("cucumber");
			vegetables.Add ("pepper");
			vegetables.Add ("carrot");

			if (fruits.Contains(item))
				Console.WriteLine ("fruit");
			else if (vegetables.Contains(item))
				Console.WriteLine ("vegetable");
			else
				Console.WriteLine ("unknown");

			return 0;
		}
	}
}