using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task8;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Main(new string[] { "multiply", "1,2,3" });
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator.Main(new string[] { "multiply", "\\,1\n,2;3,1010" });
        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculator.Main(new string[] { "multiply", "\\,1\n,2;3,-10" });
        }
    }
}
