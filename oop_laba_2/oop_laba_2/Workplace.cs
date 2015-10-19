
using System;
using System.Collections.Generic;
namespace oop_laba_2
{
	class Workplace
	{
		private List<Person> list = new List<Person>();
		private static Workplace workplace;
		static Workplace()
		{
			workplace = new Workplace ();
		}
		private Workplace(){}
		private static Workplace Instance
		{
			get{return workplace;}
		}
		public static void Add(Person obj)
		{
			Workplace place = Workplace.Instance;
			obj = new Worker (obj.Name, obj.Surname, ++place.Count);
			place.list.Add (obj);
		}
		private int Count {
			get;
			set;
		}
		public static void Show()
		{
			Workplace place = Workplace.Instance;
			foreach (Person p in place.list) {
				Console.Write(string.Format("{0}. {1} {2} : ", p.Id, p.Name, p.Surname));
				p.Work();
			}
		}
		public static void Preferment(int index)
		{
			Workplace place = Workplace.Instance;
			place.list [index-1] = new Cashier (place.list[index-1]);
		}
	}
}

