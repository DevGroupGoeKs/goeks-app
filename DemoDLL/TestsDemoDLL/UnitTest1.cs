using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoDLL;

namespace TestsDemoDLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetDieRichtigeAntwortAufAllesPos()
        {
            var sut = new Class1();
            var result = sut.GetDieRichtigeAntwortAufAlles();
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void TestGetDieRichtigeAntwortAufAllesNeg()
        {
            var sut = new Class1();
            var result = sut.GetDieRichtigeAntwortAufAlles();
            Assert.AreNotEqual(11, result);
        }
    }
}
