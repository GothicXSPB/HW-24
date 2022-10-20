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

        //public Animal(string name, int age, int weight)
        //{
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

        public Animal(string SpeciesName, string name, int age, int weight)
        {
            switch (name)
            {
                case "Wolf":
                    Diet = "predator";
                    Biom = "forest";
                    break; 

                case "Lion":
                    Diet = "predator";
                    Biom = "savannah";
                    break;

                case "Elephant":
                    Diet = "herbivorous";
                    Biom = "savannah";
                    break;
            }
            Name = name;
            Age = age;
            if (age <= _minAge)
            {
                Age = _minAge;
            }
            else
            {
                Age = age;
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
            if (mass < 0)
            {
                throw new ArgumentException("mass не может быть меньше 0");
            }
            if (Weight >= 3 * _minWeight)
            {
                Console.WriteLine($"{Name}: Больше не может есть!");
                return;
            }
            switch (food)
            {
                case "meat":
                    Console.WriteLine($"{Name}: радостно кушает!");
                    break;
                case "chiken":
                    Console.WriteLine($"{Name}: радостно кушает!");
                    break;
                case "fish":
                    Console.WriteLine($"{Name}: радостно кушает!");
                    break;
                default:
                    Console.WriteLine($"{Name}: отказывается есть это!");
                    break;
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



    }
}
