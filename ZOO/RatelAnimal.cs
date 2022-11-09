using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class RatelAnimal : AbstractAnimal
    {
        public RatelAnimal(string name, int age)
        {
            Name = name;
            Diet = "predator";
            Age = age;
        }

        public void Hunt()
        { 
        
        }
    }
}
