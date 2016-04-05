using System;

namespace ChristmasTree
{
	class MainClass
	{
		public static void Main1 (string[] args)
		{
			//Console.Write ("XMAS Tree rows to use: ");
			int user_input = int.Parse (Console.ReadLine ());
			// Console.WriteLine (user_input);

			for (int n = 1; n <= user_input + 1; n++)
			{
				string space = new string (' ', user_input - n + 1);
				string asterix = new string('*', n - 1);
				Console.Write(space + asterix + " | " + asterix + space);

				Console.WriteLine ();
			}
		}
	}


}