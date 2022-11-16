namespace ZOO
{
    public class Aviary
    {
        Aviary[] stock = new Aviary[0];
        public string Name { get; set; }

        public string Biom { get; set; }

        public int Square { get; set; }

        public Aviary(string name, string biom, int square)
        {
            Name = name;
            Biom = biom;
            Square = square;
        }

        
    }
}
