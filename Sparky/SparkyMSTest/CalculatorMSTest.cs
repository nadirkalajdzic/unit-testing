using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyMSTest
{
    [TestClass]
    class CalculatorMSTest
    {
        [TestMethod]
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
