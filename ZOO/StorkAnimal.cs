using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class StorkAnimal : AbstractAnimal
    {
        public StorkAnimal(string name, int age)
        {
            Name = name;
            Diet = "predator";
            Age = age;
        }
        public void Fly()
        { 

        }
    }
}
