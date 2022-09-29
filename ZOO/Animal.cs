namespace ZOO
{
    public class Animal
    {
        public string Name { get; set; }

        public double AmountOfFoodConsumedPerDay { get; private set; }

        public int Age { get; private set; }

        public string SpeciesName { get; private set; }

        public string Biom { get; private set; }

        public string RequiredAreaPerIndividual { get; private set; }

        public int Weight { get; private set; }

        public string Food { get; private set; }

        public string Diet { get; private set; }

        public string Sound { get; private set; }

        private const int _minWeight = 35;

        private const int _minAge = 0;

        public Animal(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            if (age <= _minAge)
            {
                Age = _minAge;
            }
            else
            {
                Age = weight;
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

        public void DoEat(string food, int mass)
        {
            if (Weight >= 3 * _minWeight)
            {
                Console.WriteLine($"{Name}: Больше не может есть {food}!");
                return;
            }
            if (food == "meat" || food == "poultry" || food == "fish")
            {
                Weight += mass;
                Console.WriteLine($"{Name}: Я поел {food}!");
            }
            else
            {
                Console.WriteLine($"{Name}: Отказывается есть {food}!");
            }
        }

        public void DoSound()
        {
            Console.WriteLine($"{Name} *рычит*");
        }

        public void Play(int time)
        {
            Weight -= time / 10;
            if (Weight < _minWeight)
            {
                Weight = _minWeight;
            }
            Console.WriteLine($"{Name} поиграл с мячиком и весит {Weight}");
        }



    }
}
