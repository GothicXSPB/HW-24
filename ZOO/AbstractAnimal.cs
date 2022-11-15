namespace ZOO
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }

        public double AmountOfFoodConsumedPerDay { get; private set; }

        protected int _age { get; set; }

        public string SpeciesName { get; set; }

        protected string _biom { get; set; }

        protected string _requiredAreaPerIndividual { get; set; }

        protected int Weight { get; set; }

        public string Food { get; set; }

        protected string _diet { get; set; }

        public string Sound { get; private set; }

        protected int _minWeight = 35;

        protected int _minAge = 0;

        public abstract void DoEat(string food, int mass);

        public void DoSound()
        {
            Console.WriteLine($"{Name} *roar*");
        }

        public void Play(int time)
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
            Console.WriteLine($"{Name} played with a ball and weighs {Weight}");
        }

        protected string[] predatorfood = new string[] { "fish", "meat", "chiken", "frog" };
        public void PredatorEatOrNo(string food)
        {
            for (int i = 0; i < 4; i++)
            {
                if (predatorfood[i] == food)
                {
                    Console.WriteLine($"{Name} eats delicious {food}");
                    return;
                }
            }
            Console.WriteLine($"{Name} refuse to eat");
        }

        protected string[] herbivorefood = new string[] { "grass", "hay" };
        public void HerbivoreEatOrNo(string food)
        {
            for (int i = 0; i < 2; i++)
            {
                if (herbivorefood[i] == food)
                {
                    Console.WriteLine($"{Name} eats delicious");
                    return;
                }
            }
            Console.WriteLine($"{Name} refuse to eat");
        }

        public void AnimalStatus()
        {
            if (Weight >= 10 * _minWeight)
            {
                Console.WriteLine($"{Name} overate and can't eat anymore");
                return;
            }
            if (Weight < _minWeight)
            {
                Console.WriteLine($"{Name} is hungry");
                return;
            }
            else
            {
                Console.WriteLine($"{Name} feels good");
            }
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

