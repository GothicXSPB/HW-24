using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class IchthyosaurAnimal : AbstractAnimal
    {
        public IchthyosaurAnimal(string name)
        {
            Name = name;
        }

        string[] predator = new string[] { "fish", "meat", "chiken", "frog" };
    }
}
