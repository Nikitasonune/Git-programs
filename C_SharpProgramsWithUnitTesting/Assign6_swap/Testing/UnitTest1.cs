using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assign6_swap;
namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program obj = new Program();
            int res = obj.swap(10, 20);
            int actual = 0;
            int expected = res;
            Assert.AreEqual(actual, expected);

        }
    }
}
