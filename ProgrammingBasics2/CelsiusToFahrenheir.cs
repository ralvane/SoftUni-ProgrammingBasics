using System;

namespace Converter {
	class Program {
		public static int Main (string[] args)
		{
			// C -> F:	F= C * 9 / 5 + 32
			// F -> C:	C= (F - 32) * 5 / 9
			Console.Write("C: ");
			var c = decimal.Parse (Console.ReadLine ());
			decimal f = c * 9 / 5 + 32;

			Console.WriteLine ("F: {0}", Math.Round(f, 2));

			return 0;
		}
	}
}