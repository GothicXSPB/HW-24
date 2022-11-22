namespace ZOO
{
    public class UnderBonnet
    {
        public void AddAnimal(AbstractAnimal a)
        {
            AbstractAnimal[] inAviary = new AbstractAnimal[0];
            if (inAviary[0] == null)
            {
                inAviary[0] = a;
            }
            else
            {
                AbstractAnimal[] result = new AbstractAnimal[(inAviary.Length) + 1];
                result = inAviary;
                result[result.Length] = a;
                result.CopyTo(inAviary, 0);
            }
        }
    }
}
