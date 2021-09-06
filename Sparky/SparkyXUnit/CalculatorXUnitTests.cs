using Xunit;

namespace Sparky
{
    public class CalculatorXUnitTests
    {
        [Fact]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // arrange
            Calculator calc = new();

            // act
            int result = calc.AddNumbers(10, 20);

            // assert
            Assert.Equal(30, result);

        }

        [Fact]
        public void OddNumber_InputEvenNumber_GetFalseResult()
        {
            // arrange
            Calculator calc = new();

            // act
            bool isOdd = calc.IsOddNumber(6);
            // assert
            Assert.False(isOdd);

        }

        [Fact]
        public void OddNumber_InputOddNumber_GetTrueResult()
        {
            // arrange
            Calculator calc = new();

            // act
            bool isOdd = calc.IsOddNumber(5);
            // assert
            Assert.True(isOdd);

        }

     
    }
}
