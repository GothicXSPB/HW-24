namespace ZOO.Test

{
    public class ZooTests
    {
        public void DoEatTest_WhenMassIsLessThenZero_ShuldArgumentExaption()
        {
            string food = "�����";
            int mass = -4;

            Assert.Throws<ArgumentException>(() => AbstractAnimal.DoEat(food, mass));
        }

        [TestCase]
        public void 
    }

}