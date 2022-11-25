using CalculatorApp;
using Xunit;

namespace Labb3_XUnitTestCalc
{
    public class MultiplicationTest
    {
        private UserApp calc = new UserApp();

        [Fact]
        public void Multiplication20MultipliedBy10Equals200()
        {
            //Arrange
            //Act
            var expected = 200;
            var actual = calc.Multiplication(20, 10);

            //Assert
            Assert.True(expected == actual );
        }

        [Theory]
        [InlineData(2, 10)]
        [InlineData(2002, 5)]
        [InlineData(1100, 10)]
        [InlineData(1, 1)]
        [InlineData(10000, 987654)]
        public void MultiplicationTheoryTest(double num1, double num2)
        {
            //Arrange
            //Act
            var expected = num1 * num2;
            var actual = calc.Multiplication(num1, num2);

            //Assert
            Assert.True(expected == actual );
        }
    }
}