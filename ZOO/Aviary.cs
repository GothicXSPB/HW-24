namespace ZOO
{
    public class Aviary
    {
        public string Name { get; set; }

        public string Biom { get; set; }

        public int Square { get; set; }

        public abstract class AbstractAnimal { }
        public bool ChekFreeSpace(Aviary x, DuckAnimal a)
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

        public void AddAnimalInAviary(DuckAnimal a)
        {
            
        }



    }
}
