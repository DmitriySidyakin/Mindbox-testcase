namespace TestProject
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestMethodR1()
        {
            Circle c = new Circle(1);
            Assert.AreEqual(c.Square, Math.PI, 0.1);
        }

        [TestMethod]
        public void TestMethodR2()
        {
            Circle c = new Circle(2);
            Assert.AreEqual(c.Square, Math.PI*4, 0.1);
        }

        [TestMethod]
        public void TestMethodR4()
        {
            Circle c = new Circle(4);
            Assert.AreEqual(c.Square, 50.265482, 0.1);
        }
    }
}