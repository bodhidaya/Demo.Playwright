using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    [TestClass]
    public class MathsTests
    {
        [TestMethod]
        public void AddTest()
        {
            // Arrange
            var num1 = 10;
            var num2 = 20;

            // Act
            var total = num1 + num2;

            // Assert
            Assert.AreEqual(30, total);
        }

        [TestMethod]
        public void SubTest()
        {
            // Subtract 20 from 10 and assert the result with expected value 10
            var num1 = 20;
            var num2 = 10;
            var total = num1 - num2;
            Assert.AreEqual(10, total);
        }
    }
}
