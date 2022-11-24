namespace ZOO
{
    public class Aviary
    {
        public string Biom { get; private set; }

        public int Square { get; private set; }

        public AbstractAnimal[] InAviary { get; private set; }

        public bool ChekFreeSpace(Aviary x, AbstractAnimal a)
        {
            if (x.Square - a.RequiredAreaPerIndividual > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Aviary(string biom, int square)
        {
            Biom = biom;
            Square = square;
        }

        public void AddAnimalInAviary(AbstractAnimal a)
        {
            for (int i = 0; i <= InAviary.Length - 1; i++)
            {

                if (Biom == a.Biom && GetFreeSpace() >= a.RequiredAreaPerIndividual &&  )
                {
                    if (Biom == a.Biom)
                    {
                        AddAnimal(a);
                        Square -= a.RequiredAreaPerIndividual;
                        Console.WriteLine($"{a.Name} was placed in an aviary {Name}");
                    }
                    else
                    {
                        Console.WriteLine($"The conditions of this aviary are not suitable for a {a.Name}");
                    }
                }
            }
        }

        public void AddAnimal(AbstractAnimal a)
        {
            AbstractAnimal[] result = new AbstractAnimal[(InAviary.Length) + 1];
            result = InAviary;
            result[result.Length] = a;
            result.CopyTo(InAviary, 0);
        }

        private int GetFreeSpace()
        {
            int freeSpace = Square;

            foreach (AbstractAnimal i in InAviary)
            {
                freeSpace -= i.RequiredAreaPerIndividual;
            }

            return freeSpace;
        }

        private bool IsItSafeToKeepThemTogether(AbstractAnimal a)
        {
            foreach (AbstractAnimal i in InAviary)
            {
                if (i.Diet != a.Diet && i.SpeciesName == a.SpeciesName || i.Diet == a.Diet)
                { }
            }
        }
    }
}
