namespace ZOO
{
    public class DuckAnimal : AbstractAnimal
    {
        public DuckAnimal(string name, int age, int weight)
        {
            SpeciesName = "bird";
            Name = name;
            _diet = "herbivore";
            if (age <= _minAge)
            {
                _age = _minAge;
            }
            else
            {
                _age = age;
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
                throw new ArgumentException("mass cannot be less than 0");
            }
            if (Weight >= 3 * _minWeight)
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
            if (Weight < _minWeight)
            {
                Weight = _minWeight;
            }
            Console.WriteLine($"{Name} walked for a while and weighs {Weight}");
        }

        public bool WillPlay(AbstractAnimal name, AbstractAnimal name1)
        {
            if (name.SpeciesName == name1.SpeciesName)
            {
                Console.WriteLine("They play together");
                return true;
            }
            else
            {
                Console.WriteLine("They avoid each other");
                return false;
            }
        }
    }
}
