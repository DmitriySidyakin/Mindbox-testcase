namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCircle()
        {
            Circle c = new Circle(1);

            
            Assert.That(c.Square, Is.EqualTo(Math.PI).Within(0.1));

        }
    }
}