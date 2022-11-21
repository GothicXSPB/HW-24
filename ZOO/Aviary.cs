using System;

namespace ZOO
{
    public class Aviary
    {
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
            AbstractAnimal[] inAviary = new AbstractAnimal[0];
            for (int i = 0; i < inAviary.Length; i++)
            {
                if (inAviary[i].Diet == a.Diet || inAviary[i].SpeciesName == a.SpeciesName && Square - a.RequiredAreaPerIndividual>0)
                {
                    if (Biom == a.Biom)
                    {
                        AbstractAnimal[] inAviary = AbstractAnimal.Append(AbstractAnimal a);
                    }
                }
            }
        }  
    }
}
