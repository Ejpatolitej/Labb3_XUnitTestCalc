using CalculatorApp;
using Xunit;

namespace Labb3_XUnitTestCalc
{
    public class DivisionTest
    {
        private UserApp calc = new UserApp();

        [Fact]
        public void Division20Dividedby10Equals2()
        {
            //Arrange
            //Act
            var expected = 2;
            var actual = calc.Division(20, 10);

            //Assert
            Assert.True(expected == actual );
        }

        [Theory]
        [InlineData(2, 10)]
        [InlineData(2002, 5)]
        [InlineData(1100, 10)]
        [InlineData(1, 1)]
        [InlineData(10000, 987654)]
        public void DivisionTheoryTest(double num1, double num2)
        {
            //Arrange
            //Act
            var expected = num1 / num2;
            var actual = calc.Division(num1, num2);

            //Assert
            Assert.True(expected == actual );
        }
    }
}