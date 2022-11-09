

namespace ZOO
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }

        public double AmountOfFoodConsumedPerDay { get; private set; }

        public int Age { get; set; }

        public string SpeciesName { get; private set; }

        public string Biom { get; private set; }

        public string RequiredAreaPerIndividual { get; private set; }

        public int Weight { get; private set; }

        public string Food { get; set; }

        public string Diet { get; set; }

        public string Sound { get; private set; }

        private const int _minWeight = 35;

        private const int _minAge = 0;

        //public AbstractAnimal(string SpeciesName, string name, int age, int weight)
        //{
        //    switch (SpeciesName)
        //    {
        //        case "Wolf":
        //            Diet = "predator";
        //            Biom = "forest";
        //            break;

        //        case "Lion":
        //            Diet = "predator";
        //            Biom = "savannah";
        //            break;

        //        case "Elephant":
        //            Diet = "herbivorous";
        //            Biom = "savannah";
        //            break;
        //    }
        //    Name = name;
        //    Age = age;
        //    if (age <= _minAge)
        //    {
        //        Age = _minAge;
        //    }
        //    else
        //    {
        //        Age = age;
        //    }
        //    if (weight <= _minWeight)
        //    {
        //        Weight = _minWeight;
        //    }
        //    else
        //    {
        //        Weight = weight;
        //    }
        //}

        public void DoEat(string food, int mass)
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

        private void PredatorEatOrNo(string food)
        {
            string[] predatorfood = new string[] { "fish", "meat", "chiken", "frog" };
            for (int i = 0; i < GetLength(predatorfood); i++)
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

        private void HerbivoreEatOrNo(string food)
        {
            string[] herbivorefood = new string[] { "grass", "hay" };
            for (int i = 0; i < GetLength(herbivorefood); i++)
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
