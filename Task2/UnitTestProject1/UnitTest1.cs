using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Main(new string[] { "add", "10,20,30" });
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator.Main(new string[] { "add" });
        }
    }
}
