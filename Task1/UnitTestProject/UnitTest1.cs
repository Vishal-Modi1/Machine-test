using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Main(new string[] { "sum", "10,20" });
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator.Main(new string[] { "sum" });
        }

    }
}
