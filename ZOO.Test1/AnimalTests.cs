namespace ZOO.Test
{
    public class ZooTests
    {
        [Test]
        public void DoEatTest_WhenMassIsLessThenZero_ShouldArgumentException()
        {
            DuckAnimal duck3 = new DuckAnimal("ds", 4, 15);
            string food = "frog";
            int mass = -4;

            Assert.Throws<ArgumentException>(() => duck3.DoEat(food, mass));
        }

        [Test]
        public void WalksTest_WhenTimeIsLessThenZero_ShouldArgumentException()
        {
            DuckAnimal duck3 = new DuckAnimal("ds", 4, 15);
            int time = -4;

            Assert.Throws<ArgumentException>(() => duck3.Walks(time));
        }

        [Test]
        public void SwimTest_WhenTimeIsLessThenZero_ShouldArgumentException()
        {
            TurtleAnimal dino1 = new TurtleAnimal("dino", 4, 44);
            int time = -4;

            Assert.Throws<ArgumentException>(() => dino1.Swim(time));
        }

        [Test]
        public void HuntTest_WhenTimeIsLessThenZero_ShouldArgumentException()
        {
            RatelAnimal beast = new RatelAnimal("beast", 4, 44);
            int time = -4;

            Assert.Throws<ArgumentException>(() => beast.Hunt(time));
        }

        [Test]
        public void FlyTest_WhenTimeIsLessThenZero_ShouldArgumentException()
        {
            StorkAnimal baby = new StorkAnimal("baby", 4, 44);
            int time = -4;

            Assert.Throws<ArgumentException>(() => baby.Fly(time));
        }
    }
}