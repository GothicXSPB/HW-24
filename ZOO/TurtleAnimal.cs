namespace ZOO
{
    public class TurtleAnimal : AbstractAnimal
    {
        public TurtleAnimal(string name, int age, int weight)
        {
            SpeciesName = "reptiles";
            Name = name;
            _diet = "herbivore";
            Biom = "savannah";
            RequiredAreaPerIndividual = 1;
            AmountOfFoodConsumedPerDay = 1;

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

        public void Swim(int time)
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
            Console.WriteLine($"{Name} swam many miles and weighs {Weight}");
        }
    }
}
