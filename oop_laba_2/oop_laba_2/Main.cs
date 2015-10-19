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

	class Person
	{
		protected string name, surname;
		public virtual int Id{ get; set;}
		public string Name{
			get{return name;}
		}
		public string Surname{
			get{return surname;}
		}
		public Person(string name, string surname)
		{
			this.name = name;
			this.surname = surname;
		}
		public Person(){}
		public virtual void Work()
		{
			Console.WriteLine ("Unemployed person");
		}
	}
	class Worker:Person
	{
		int id;
		public override int Id{
			get {return id;}
			set{id = value;}
		}
		public Worker(string name, string surname, int id){
			this.name = name;
			this.surname = surname;
			this.id = id;
		}
		public  Worker(){
		}
		public Worker(string name, string surname):base(name, surname)
		{

		}
		public override void Work()
		{
			Console.WriteLine ("Just a worker");
		}
	}
	class Cashier:Worker
	{
		public Cashier (Person obj)
		{
			this.name = obj.Name;
			this.surname = obj.Surname;
			this.Id = obj.Id;
		}
		public override void Work()
		{
			Console.WriteLine ("Oh, it is a cashier");
		}
	}

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
