using CalculatorLib.Swabhav;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLib.Tests
{
    [TestClass]
    public class CalciTest
    {
        Calculator calci = new Calculator();

        [TestMethod]
        public void TestCaclculatorCubeMethod()
        {
            Assert.AreEqual(9, calci.CubeEvenNumber(2));          
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCalciWithException()
        {
            calci.CubeEvenNumber(3);
        }

    }
}
