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
			ulong seconds = minutes * 60;
			decimal milliseconds = (decimal)seconds * 1000;
			decimal microseconds = milliseconds * 1000;
			decimal nanoseconds = microseconds * 1000;

			Console.WriteLine ($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} " +
				$"minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
		}
	}
}