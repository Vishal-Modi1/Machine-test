using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Main(new string[] { "add", "\\;\\3;4;5" });
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator.Main(new string[] { "add", "\\;\\3;\\4;\\5" });
        }
    }
}

