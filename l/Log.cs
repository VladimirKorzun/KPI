using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l
{
    static class Log
    {
        public static void ToLog(string date, string action, string condition)
        {
            System.IO.File.AppendAllText(@"d:\log.txt", string.Format("\n[{0}][{1}][{2}];", date, action, condition) + Environment.NewLine);
        }   
    }
}
