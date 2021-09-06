using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    class GradingCalculatorNUnitTests
    {

        private GradingCalculator gradingCalculator;

        [SetUp]
        public void SetUp()
        {
            gradingCalculator = new GradingCalculator();
        }

        [Test]
        public void GradeCalc_InputScore95Attendance90_GetAGrade()
        {

            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 90;
            
            string result = gradingCalculator.GetGrade();

            Assert.That(result, Is.EqualTo("A"));

        }

        [Test]
        public void GradeCalc_InputScore95Attendance65_GetBGrade()
        {

            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 90;

            string result = gradingCalculator.GetGrade();

            Assert.That(result, Is.EqualTo("A"));

        }

    }
}
