using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void DivOneByOne()
        {
            var calculator = new Calculator();

            var expected = 1;

            var actual = calculator.Div(1, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivTwoByOne()
        {
            var calculator = new Calculator();

            var actual = calculator.Div(2, 1);

            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivByZero()
        {
            var calculator = new Calculator();

            calculator.Div(2, 0);
        }
    }
}