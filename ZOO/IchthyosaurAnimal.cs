using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOO
{
    public class IchthyosaurAnimal : AbstractAnimal
    {
        public IchthyosaurAnimal(string name, int age, int weight)
        {
            SpeciesName = "reptiles";
            Name = name;
            Diet = "predator";
            if (age <= _minAge)
            {
                Age = _minAge;
            }
            else
            {
                Age = age;
            }
            if (weight <= _minWeight)
            {
                Weight = _minWeight;
            }
            else
            {
                Weight = weight;
            }
        }

        public override void DoEat(string food, int mass)
        {
            if (mass < 0)
            {
                throw new ArgumentException("mass не может быть меньше 0");
            }
            if (Weight >= 3 * _minWeight)
            {
                Console.WriteLine($"{Name}: Больше не может есть!");
                return;
            }
            if (Diet == "predator")
            {
                PredatorEatOrNo(food);
            }
            if (Diet == "herbivorous")
            {
                HerbivoreEatOrNo(food);
            }
        }

        public void Swimming(int time)
        {
            if (time < 0)
            {
                throw new ArgumentException("time не может двигаться в другую сторону");
            }
            Weight -= time / 10;
            if (Weight < _minWeight)
            {
                Weight = _minWeight;
            }
            Console.WriteLine($"{Name} проплыл много миль и весит {Weight}");
        }

    }
}
