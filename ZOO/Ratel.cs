namespace ZOO
{
    public class Ratel
    {
        public string Name { get; set; }

        public double AmountOfFoodConsumedPerDay { get;private set; }

        public int Age { get; private set; }

        public string SpeciesName { get; private set; }

        public string Biom { get; private set; }

        public string RequiredAreaPerIndividual { get; private set; }

        public string Food { get; private set; }

        public string Diet { get; private set; }

        public string Sound { get; private set; }      

        public void DoEat()
        {
            Console.WriteLine($"{Name}: Я поел!");
        }

        public void DoSound()
        {
            Console.WriteLine($"{Name} *рычит*");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} играет с мячиком");
        }
    }
}
