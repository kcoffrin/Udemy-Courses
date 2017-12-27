using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApp1.MathOperations.Double(10);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(20, ConsoleApp1.MathOperations.Double(10));
        }
    }
}
