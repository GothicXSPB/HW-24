namespace ZOO
{
    public class Aviary
    {
        AbstractAnimal[] inAviary = new AbstractAnimal[0];

        public string Name { get; set; }

        public string Biom { get; set; }

        public int Square { get; set; }

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
        public Aviary(string name, string biom, int square)
        {
            Name = name;
            Biom = biom;
            Square = square;
        }

        public void AddAnimalInAviary(AbstractAnimal a)
        {
            for (int i = 0; i <= inAviary.Length-1; i++)
            {
                if (inAviary[0] == null)
                {
                    inAviary[0] = a;
                }
                if (inAviary[i].Diet == a.Diet || inAviary[i].SpeciesName == a.SpeciesName && Square - a.RequiredAreaPerIndividual >= 0)
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
            AbstractAnimal[] result = new AbstractAnimal[(inAviary.Length) + 1];
            result = inAviary;
            result[result.Length] = a;
            result.CopyTo(inAviary, 0);
        }
    }
}
