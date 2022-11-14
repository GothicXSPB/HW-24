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
            PredatorEatOrNo(food);
        }

        public void Hunt(int time)
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
            Console.WriteLine($"{Name} spent a lot of energy hunting and weighs {Weight}");
        }
    }
}
