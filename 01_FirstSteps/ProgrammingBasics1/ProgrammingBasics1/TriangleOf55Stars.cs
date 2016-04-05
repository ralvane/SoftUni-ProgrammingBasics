using System;

namespace TriangleOf55Stars
{
	class MainClass
	{
		static void Main1 (string[] args)
		{
			for (int i = 1; i <= 10; i++) {
				var asterix = new string ('*', i);
				Console.WriteLine (asterix);
			}
		}
	}
}