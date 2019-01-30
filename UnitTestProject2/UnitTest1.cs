using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Fail()
        {
            Console.WriteLine("Failing this test to check logs");
            Assert.Fail("Fail this");
        }

        [TestMethod]
        public void TestMethod_Pass()
        {
            Console.WriteLine("Pass test logs; never appears");
        }
    }
}
