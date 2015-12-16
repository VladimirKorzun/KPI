using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Model
{
    public class Zoo:IStrategy<Animal>
    {
        private string name;
        private List<Animal> animals;
        public Zoo(string name)
        {
            animals = new List<Animal>();
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
        public void AddToStruct(Animal obj)
        {
            animals.Add(obj);
        }

        public void RemoveFromStruct(Animal obj)
        {
            animals.Remove(obj);
        }

        public List<Animal> ThisStruct()
        {
            return animals;
        }
    }
}
