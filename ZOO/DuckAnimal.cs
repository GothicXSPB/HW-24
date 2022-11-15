namespace ZOO
{
    public class DuckAnimal : AbstractAnimal
    {
        public DuckAnimal(string name, int age, int weight)
        {
            SpeciesName = "bird";
            Name = name;
            _diet = "herbivore";
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
            HerbivoreEatOrNo(food);
        }

        public void Walks(int time)
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
            Console.WriteLine($"{Name} walked for a while and weighs {Weight}");
        }
    }
}
