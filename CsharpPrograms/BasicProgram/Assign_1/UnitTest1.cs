using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
namespace Assign_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /*  welcome obj = new welcome();
              string res= obj.method2("Welcome Friends!");
              string actual= "Have a nice day!";
              string expected = res;
              Assert.AreEqual(actual, expected);*/



            Program obj = new Program();
            int res = obj.addition(10,50);
            int actual = 60;
            int expected = res;
            Assert.AreEqual(actual, expected);
        }
    }
}
