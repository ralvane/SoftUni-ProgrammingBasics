using System;

namespace RectangleArea
{
	class Program
	{
		static void Main1 (string[] args)
		{
			var a = decimal.Parse (Console.ReadLine ());
			var b = decimal.Parse (Console.ReadLine ());

			Console.WriteLine (a * b);
		}
	}
}