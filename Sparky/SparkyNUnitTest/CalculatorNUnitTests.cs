using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // arrange
            Calculator calc = new();

            // act
            int result = calc.AddNumbers(10, 20);

            // assert
            Assert.AreEqual(30, result);

        }

        [Test]
        public void OddNumber_InputEvenNumber_GetFalseResult()
        {
            // arrange
            Calculator calc = new();

            // act
            bool isOdd = calc.IsOddNumber(6);
            // assert
            Assert.AreEqual(isOdd, false);

        }

        [Test]
        public void OddNumber_InputOddNumber_GetTrueResult()
        {
            // arrange
            Calculator calc = new();

            // act
            bool isOdd = calc.IsOddNumber(5);
            // assert
            Assert.AreEqual(isOdd, true);

        }
    }
}
