namespace _05_Elevator
{
	using System;

	class Program
	{
		public static void Main()
		{
			uint persons = uint.Parse (Console.ReadLine ());
			uint capacity = uint.Parse (Console.ReadLine ());

			uint elevatorTrips = (uint)Math.Ceiling((double)persons / capacity);

			Console.WriteLine (elevatorTrips);
		}
	}
}