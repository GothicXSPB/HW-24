namespace ZOO
{
    public abstract class AbstractAnimal
    {
        protected string[] PredatorFood = new string[] { "fish", "meat", "chicken", "frog" };
        
        protected string[] HerbivoreFood = new string[] { "grass", "hay" };
        
        protected int MinWeight = 35;
        
        protected int MinAge = 0;

        public string Name { get; set; }

        public int AmountOfFoodConsumedPerDay { get; set; }

        protected int _age { get; set; }

        public string SpeciesName { get; set; }

        public string Biom { get; set; }

        public int RequiredAreaPerIndividual { get; set; }

        protected int Weight { get; set; }

        public string Food { get; set; }

        public string Diet { get; set; }

        public string Sound { get; private set; }



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
            if (Weight < MinWeight)
            {
                Weight = MinWeight;
            }
            Console.WriteLine($"{Name} played with a ball and weighs {Weight}");
        }

        public void PredatorEatOrNo(string food)
        {
            for (int i = 0; i < 4; i++)
            {
                if (PredatorFood[i] == food)
                {
                    Console.WriteLine($"{Name} eats delicious {food}");
                    return;
                }
            }
            Console.WriteLine($"{Name} refuse to eat");
        }

        public void HerbivoreEatOrNo(string food)
        {
            for (int i = 0; i < 2; i++)
            {
                if (HerbivoreFood[i] == food)
                {
                    Console.WriteLine($"{Name} eats delicious");
                    return;
                }
            }
            Console.WriteLine($"{Name} refuse to eat");
        }

        public void AnimalStatus()
        {
            if (Weight >= 10 * MinWeight)
            {
                Console.WriteLine($"{Name} overate and can't eat anymore");
                return;
            }
            if (Weight < MinWeight)
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
            if (name._diet == name1._diet)
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

