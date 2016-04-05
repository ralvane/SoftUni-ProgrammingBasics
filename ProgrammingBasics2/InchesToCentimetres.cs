using System;

namespace InchesToCentimetres {
	class Program {
		public static int Main (string[] args)
		{
			var inches = double.Parse (Console.ReadLine ());
			var centimetres = inches * 2.54;

			Console.WriteLine ("Centemetres: " + centimetres);

			return 0;
		} // Main()
	} // class Program
} // namespace