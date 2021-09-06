

using Xunit;

namespace Sparky
{
    public class GradingCalculatorXUnitTests
    {

        private GradingCalculator gradingCalculator;

        public GradingCalculatorXUnitTests()
        {
            gradingCalculator = new GradingCalculator();
        }

        [Fact]
        public void GradeCalc_InputScore95Attendance90_GetAGrade()
        {

            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 90;
            
            string result = gradingCalculator.GetGrade();

            Assert.Equal("A", result);

        }

    }
}
