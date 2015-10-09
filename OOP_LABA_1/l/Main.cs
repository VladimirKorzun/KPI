using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace l
{ 
	class Program
	{ 
		static void Main(string[] args)
		{
			Log.ToLog(DateTime.Now.ToString(), "start", "-----------------------------");
			Controller cont = new Controller();
			FileReader file = new FileReader();
			file.Reader(cont);
			file.Writer(cont);
			Log.ToLog(DateTime.Now.ToString(), "end", "-------------------------------");
		}
	}
}