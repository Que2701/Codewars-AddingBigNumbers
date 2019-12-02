using System;
using AddingBigNumbersApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddingBigNumbersUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("444", Program.Add("123", "321"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("9223372036854775807", Program.Add("‭4611686018427387903.5‬", "‭4611686018427387903.5‬"));
        }
    }
}
