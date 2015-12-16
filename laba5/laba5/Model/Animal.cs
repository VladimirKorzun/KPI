using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Model
{
    public abstract class Animal
    {
        private string name, comment;
        private int age;
        public Animal(string name, int age, string comment) {
            this.name = name;
            this.age = age;
            this.comment = comment;
        }
        public string Name
        {
            get { return name; }
        }
        public string Comment
        {
            get { return comment; }
        }
        public int Age
        {
            get { return age; }
        }
        public abstract string AnimalSleeps();
        public abstract string AnimalWakeUp();

    }
}
