namespace ZOO
{
    public class RatelAnimal : AbstractAnimal
    {
        public RatelAnimal(string name, int age, int weight)
        {
            SpeciesName = "mammals";
            Name = name;
            _diet = "predator";
            _age = age;
            Biom = "savannah";
            RequiredAreaPerIndividual = 10;
            AmountOfFoodConsumedPerDay = 3;

            if (age <= MinAge)
            {
                _age = MinAge;
            }
            else
            {
                _age = age;
            }
            if (weight <= MinWeight)
            {
                Weight = MinWeight;
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
                throw new ArgumentException("mass cannot be less than 0");
            }
            if (Weight >= 3 * MinWeight)
            {
                Console.WriteLine($"{Name}: Can't eat anymore!");
                return;
            }
            PredatorEatOrNo(food);
        }

        public void Hunt(int time)
        {
            if (time < 0)
            {
                throw new ArgumentException("time cannot move the other way");
            }
            Weight -= time / 10;
            if (Weight < MinWeight)
            {
                Weight = MinWeight;
            }
            Console.WriteLine($"{Name} spent a lot of energy hunting and weighs {Weight}");
        }
    }
}
