using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba5.Model;

namespace laba5.Controller
{
    public class ZooCont
    {
        private Zoo zoo;
        public ZooCont(Zoo zoo)
        {
            this.zoo = zoo;
        }
        public void AddAnAnimal(string name, int age, string comment)
        {
            zoo.AddToStruct(new Mammal(name, age, comment));
        }
        public void DeleteAnAnimal(int index)
        {
            zoo.RemoveFromStruct(zoo.ThisStruct().ElementAt(index));
        }      
        public List<Animal> ReturnZoo()
        {
            return zoo.ThisStruct();
        }
    }
}
