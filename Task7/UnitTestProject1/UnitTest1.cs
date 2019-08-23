using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task7;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Main(new string[] { "add", "999,1001" });
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator.Main(new string[] { "add", "10,20,1010,20" });
        }
    }
}
