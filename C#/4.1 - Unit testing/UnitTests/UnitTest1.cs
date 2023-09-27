using QACalculator;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        readonly Calculator calculator = new();

        #region Divide
        [TestMethod]
        public void Divide_ValidString_CalculatesResult()
        {
            // Arrange
            var input = "100,10";

            // Act
            var output = calculator.Divide(input);

            // Assert
            var expected = 10;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Divide_InvalidString_ThrowsFormatException()
        {
            // Arrange
            var input = "100,A";

            // Act
            calculator.Divide(input);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Divide_NullString_ThrowsNullReferenceException()
        {
            // Arrange
            string input = null!;

            // Act
            calculator.Divide(input);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            string input = "100,0";

            // Act
            calculator.Divide(input);
        }
        #endregion

        #region Multiply
        [TestMethod]
        public void Multiply_ValidString_CalculateResult()
        {
            // Arrange
            var input = "100,10";

            // Act
            var output = calculator.Multiply(input);

            // Assert
            var expected = 1000;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Multiply_InvalidString_ThrowFormatException()
        {
            // Arrange
            var input = "100,A";

            // Act
            calculator.Multiply(input);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Multiply_InvalidString_ThrowNullReferenceException()
        {
            // Arrange
            string input = null!;

            // Act
            calculator.Multiply(input);
        }
        #endregion

        #region Subtract
        [TestMethod]
        public void Subtract_ValidString_CalculateResult()
        {
            // Arrange
            var input = "100,10";

            // Act
            var output = calculator.Subtract(input);

            // Assert
            var expected = 90;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Subtract_InvalidString_ThrowFormatException()
        {
            // Arrange
            var input = "100,A";

            // Act
            calculator.Subtract(input);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Subtract_InvalidString_ThrowNullReferenceException()
        {
            // Arrange
            string input = null!;

            // Act
            calculator.Subtract(input);
        }
        #endregion
    }
}