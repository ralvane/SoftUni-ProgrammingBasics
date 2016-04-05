namespace _01_CenturiesToMinutes
{
	using System;

	class Program
	{
		public static void Main()
		{
			ushort centuries = ushort.Parse (Console.ReadLine ());

			uint years = centuries * (uint)100;
			ulong days = (ulong)(years * 365.2422);
			ulong hours = days * 24;
			ulong minutes = hours * 60;

			Console.WriteLine ($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
		}
	}
}