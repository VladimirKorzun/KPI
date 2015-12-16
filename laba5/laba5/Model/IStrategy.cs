using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Model
{
    interface IStrategy<T>
    {
        void AddToStruct(T obj);
        void RemoveFromStruct(T obj);
        List<T> ThisStruct();
    }
}
