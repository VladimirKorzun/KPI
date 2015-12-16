using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5.Model
{
    class Mammal : Animal
    {
        public Mammal(string name, int age, string comment) : base(name, age, comment) { }

        public override string AnimalSleeps()
        {
            return string.Format("It is a mammal. {0} is sleeping now!", this.Name);
        }

        public override string AnimalWakeUp()
        {
            return string.Format("It is a mammal. {0} does its job!", this.Name);
        }
    }
}
