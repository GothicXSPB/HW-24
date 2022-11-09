namespace ZOO
{
    public abstract class AbstractAnimal
    {
        public string Name { get; set; }

        public double AmountOfFoodConsumedPerDay { get; set; }

        public int Age { get; set; }

        public string SpeciesName { get; set; }

        public string Biom { get; set; }

        public string RequiredAreaPerIndividual { get; set; }

        public int Weight { get; set; }

        public string Food { get; set; }

        public string Diet { get; set; }

        public string Sound { get; set; }

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
