using System;
using Gtk;

using Nakov.TurtleGraphics;

namespace TurtleGraphics
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			FormTurtleGraphics win = new FormTurtleGraphics ();
			win.Show ();
			Application.Run ();
		}
	}
}
