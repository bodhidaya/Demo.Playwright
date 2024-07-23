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

        // TODO: write the subtract test
    }
}
