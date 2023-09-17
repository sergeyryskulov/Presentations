using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {       
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