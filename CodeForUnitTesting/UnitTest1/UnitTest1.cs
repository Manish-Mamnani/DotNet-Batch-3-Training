using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorService;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calcObj = null;

        public UnitTest1()
        {
            calcObj = new Calculator();
        }
        [TestMethod]
        public void TestMethod1()
        {
            int numTest1 = 100;
            int numTest2 = 200;
            int actual = 0;
            int expected = 300;
            actual = calcObj.Addme(numTest1, numTest2);
            Assert.AreEqual(expected, actual);
        }
    }
}
