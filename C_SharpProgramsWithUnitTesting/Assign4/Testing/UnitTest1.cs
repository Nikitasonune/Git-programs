using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using Assign4;
namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program obj = new Program();
            int[] c = { 1, 2, 3, 4, 5 };
            int res = obj.function(c);
            int actual = 15;
            int expected = res;
            Assert.AreEqual(actual, expected);

        }
    }
}
