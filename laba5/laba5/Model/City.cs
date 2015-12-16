using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Model
{
    class City : IStrategy<Zoo>
    {
        private List<Zoo> zoos;
        public City()
        {
            zoos = new List<Zoo>();
        }
        public void AddToStruct(Zoo obj)
        {
            zoos.Add(obj);
        }

        public void RemoveFromStruct(Zoo obj)
        {
            zoos.Remove(obj);
        }

        public List<Zoo> ThisStruct()
        {
            return zoos;
        }
    }
}
