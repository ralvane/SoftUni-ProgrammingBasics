using System;
using System.Globalization;


namespace DaysAfterBirth {
	class Program {
		public static int Main(string[] args)
		{
			var birthdate_str = Console.ReadLine ();
			DateTime birthdate = DateTime.ParseExact (birthdate_str, "dd-MM-yyyy", CultureInfo.InvariantCulture);

			DateTime result = birthdate.AddDays (999);

			Console.WriteLine (result.ToString("dd-MM-yyyy"));

			return 0;
		}
	}
}