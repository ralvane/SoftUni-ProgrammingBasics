using System;

namespace HelloCSharp {
	class Program
	{
		static void Main2 (string[] args)
		{
			try
			{
				Console.WriteLine ("Hello C#");
			}
			catch (Exception e)
			{
				Console.WriteLine ("Грешка" + e);
			}
		}
	}
}