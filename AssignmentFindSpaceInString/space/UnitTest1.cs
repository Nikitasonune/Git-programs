using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_prog4;
namespace space
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program obj = new Program();
            int res = obj.function("my name m");
            int actual = 2;
            int expected = res;
            Assert.AreEqual(actual, expected);
        }
    }
}
