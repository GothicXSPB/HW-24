using System;

namespace ZOO
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }

        public double AmountOfFoodConsumedPerDay { get; private set; }

        public int Age { get; set; }

        public string SpeciesName { get; set; }

        public string Biom { get; private set; }

        public string RequiredAreaPerIndividual { get; private set; }

        public int Weight { get; set; }

        public string Food { get; set; }

        public string Diet { get; set; }

        public string Sound { get; private set; }

        public int _minWeight = 35;

        public int _minAge = 0;

        public abstract void DoEat(string food, int mass);               
                        
        public void DoSound()
        {
            Console.WriteLine($"{Name} *рычит*");
        }

        public void Play(int time)
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
            Console.WriteLine($"{Name} поиграл с мячиком и весит {Weight}");
        }

        public void PredatorEatOrNo(string food)
        {
            string[] predatorfood = new string[] { "fish", "meat", "chiken", "frog" };
            for (int i = 0; i < 4; i++)
            {
                if (predatorfood[i] == food)
                {
                    Console.WriteLine($"{Name} охотно кушает {food}");
                }
                else
                {
                    Console.WriteLine($"{Name} отказывается это есть");
                }
            }
        }

        public void HerbivoreEatOrNo(string food)
        {
            string[] herbivorefood = new string[] { "grass", "hay" };
            for (int i = 0; i < 2; i++)
            {
                if (herbivorefood[i] == food)
                {
                    Console.WriteLine($"{Name} охотно поглащает пищу, которую ему дали");
                }
                else
                {
                    Console.WriteLine($"{Name} отказывается это есть");
                }
            }
        }



    }
}
