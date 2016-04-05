using System;
using Gtk;

using Nakov.TurtleGraphics;

public partial class FormTurtleGraphics: Gtk.Window
{
	public FormTurtleGraphics () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	private void buttonDraw_Click(object sender, EventArgs e)
	{	
		Turtle.Forward (200);
		Turtle.Rotate(30);
		Turtle.Forward(200);
		Turtle.Rotate(120);
		Turtle.Forward(200);
		Turtle.Rotate(120);
		Turtle.Forward(200);
	}


}
