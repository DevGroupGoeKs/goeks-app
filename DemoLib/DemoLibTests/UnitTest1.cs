using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoLib;

namespace DemoLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetDieAntwortAufAlleFrangenPos()
        {
            var sut = new DemoClass();
            var res = sut.GetDieAntwortAufAlleFrangen();
            Assert.AreEqual(42, res);
        }

        [TestMethod]
        public void TestGetDieAntwortAufAlleFrangenNeg1()
        {
            var sut = new DemoClass();
            var res = sut.GetDieAntwortAufAlleFrangen();
            Assert.AreNotEqual(1, res);
        }

        [TestMethod]
        public void TestGetDieAntwortAufAlleFrangenNeg2()
        {
            var sut = new DemoClass();
            var res = sut.GetDieAntwortAufAlleFrangen();
            Assert.AreNotEqual(50, res);
        }

        [TestMethod]
        public void TestGetDieAntwortAufAlleFrangenNegSollFehlschalgen()
        {
            var sut = new DemoClass();
            var res = sut.GetDieAntwortAufAlleFrangen();
            Assert.AreEqual(25, res);
        }

    }
}
