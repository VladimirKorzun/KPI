using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l
{
	class Controller
	{
		private List<Base> list;
		public Controller()
		{
			list = new List<Base>();
		}
		public void Add(Base newBase)
		{
			list.Add(newBase);
		}
		public Base this[string name]
		{
			get
			{
				foreach (Base newBase in list)
				{
					if (newBase.Name == name)
						return newBase;
				}
				return null;
			}
		}
		public static Base Add(Base first, Base second)
		{
			return first.Add(second);
		}
		public static Base Sub(Base first, Base second)
		{
			return first.Sub(second);
		}
		public static Base Mult(Base first, Base second)
		{
			return first.Mult(second);
		}
		public static Base Mult(Base first, int number)
		{
			return first.Mult(number);
		}
		public static int Scalar(Base first, Base second)
		{
			return first.Scalar(second);
		}
		public static int Evkl(Base first)
		{
			return first.Evkl();
		}
		public static Base Combine(Base first, Base second)
		{
			return first.Combine(second);
		}
		public static Base operator +(Base first, Base second)
		{
			return first.Add(second);
		}
	}
}

