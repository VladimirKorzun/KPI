using System;
using System.Collections.Generic;

namespace oop_laba_2
{


	class MainClass
	{
		public static void Main (string[] args)
		{
			Person p = new Person ("Bogdan", "Oros");
			Person a = new Person ("Boris", "Topchiev");
			Workplace.Add (p);
			Workplace.Add (a);
			Workplace.Show ();
			Console.WriteLine ();
			Workplace.Preferment (1);
			Workplace.Show ();
		}
	}
}
