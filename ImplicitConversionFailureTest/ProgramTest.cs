using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImplicitConversionFailure;

namespace ImplicitConversionFailureTest
{
    [TestClass]
    public class ProgramTest
    {
        private decimal expectedDecimalPlaces = 2;

        [TestMethod]
        public void Test2DecimalPoint_WithDecimal_ExpectSuccess()
        {
            decimal i = 0.01m;
            int actual = Program.Precision(i);
            Assert.AreEqual(actual, expectedDecimalPlaces);
        }

        [TestMethod]
        public void Test2DecimalPoint_CastFromFloat_ExpectSuccess()
        {
            float i = 0.01f;
            int actual = Program.Precision((decimal)i);
            Assert.AreEqual(actual, expectedDecimalPlaces);
        }

    }
}
