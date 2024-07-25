namespace GettingStarted.Basics
{
    [TestClass]
    public class CalculatorTests
    {
        [DataTestMethod(displayName: "Test case 001 - Adding numbers")]
        [DataRow(10.0, 20.0, 30.0, DisplayName = "Adding positive numbers")]
        [DataRow(10.0, -20, -10, DisplayName = "Adding positive and negative numbers")]
        [DataRow(0, 0, 0, DisplayName = "Adding zeros")]
        [DataRow(-10, -20, -30, DisplayName = "Adding negative numbers")]
        [DataRow(-10.132, -20.234, -30.366, DisplayName = "Adding negative numbers with three number precision")]
        public void Adding(double input1, double input2, double expected)
        {
            var calculator = new Calculator();
            var total = calculator.Add((decimal)input1, (decimal)input2);
            Assert.AreEqual((decimal)expected, total);
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