using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GettingStarted
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Adding()
        {
            Calculator calculator = new Calculator();
            var total = calculator.Add(10, 20);

            Assert.AreEqual(30, total);
        }

        [TestMethod]
        public void Substracting()
        {
            Calculator calculator = new Calculator();
            var total = calculator.Subtract(40, 30);
            Assert.AreEqual(10, total);
        }

        [TestMethod]
        public void Multiplying()
        {
            Calculator calculator = new Calculator();
            var total = calculator.Multiply(25, 3);
            Assert.AreEqual(75, total);
        }

        [TestMethod]
        public void Deviding()
        {
            Calculator calculator = new Calculator();
            var total = calculator.Divide(60, 15);
            Assert.AreEqual(4, total);
        }

         [TestMethod]
        public void Remainder()
        {
            Calculator calculator = new Calculator();
            var total = calculator.Remainder(62, 15);
            Assert.AreEqual(2, total);
        }

    }
}