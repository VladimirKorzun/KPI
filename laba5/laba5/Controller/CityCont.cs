using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba5.Model;

namespace laba5.Controller
{
    public class CityCont
    {
        public List<string> list = new List<string>();
        private City city;
        public CityCont() {
            city = new City();
            list.Add("A");
            list.Add("B");
        }
        public void CreateAZoo(string zooName)
        {
            city.AddToStruct(new Zoo(zooName));
        }
        public void DestroyTheZoo(int index)
        {
            if (index != -1)
            {
                city.RemoveFromStruct(city.ThisStruct().ElementAt(index));
            }
        }
        public Zoo GetZoo(int index)
        {
            if (index != -1)
                return city.ThisStruct().ElementAt(index);
            else throw new NullReferenceException();
        }
    }
}
