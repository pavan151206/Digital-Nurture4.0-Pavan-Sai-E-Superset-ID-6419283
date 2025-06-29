namespace MyApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator(); 
        }

        [Test]
        public void Add()
        {
            int result = calc.Add(5, 7);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Subtract()
        {
            int result = calc.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }
    }
}
