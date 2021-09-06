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
    }
}
