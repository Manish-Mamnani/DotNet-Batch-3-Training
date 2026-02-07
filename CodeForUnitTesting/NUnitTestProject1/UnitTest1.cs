using CalculatorService;
using NUnit.Framework.Legacy;
namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        Calculator _calculator = null;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void TestMethod1()
        {
            int numTest1 = 100;
            int numTest2 = 200;
            int actual = 0;
            int expected = 300;
            actual = _calculator.Addme(numTest1, numTest2);
            Assert.Equals(expected, actual);
        }
    }
}
