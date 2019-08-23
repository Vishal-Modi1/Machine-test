using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Main(new string[] { "add", "\\,\\3,-44,5" });
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator.Main(new string[] { "add", "\\,\\-3,-44,5" });
        }
    }

}
