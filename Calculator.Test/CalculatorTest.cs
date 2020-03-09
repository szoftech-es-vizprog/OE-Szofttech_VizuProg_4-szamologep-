using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestEmptyString()
        {
            var t = new CalculatorCore();
            var ered = t.Feldolgoz("");

        }

        [TestMethod]
        public void Sum()
        {
            var t = new CalculatorCore();
            object ered = t.Feldolgoz("3+5");
            Assert.AreEqual(8, ered);
        }
    }

}
