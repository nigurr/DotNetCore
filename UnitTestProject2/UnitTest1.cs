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
        
        [TestMethod]
        public void TestMethod_Ascii()
        {
            var d = "7 días";
            Assert.AreEqual("7 días", d);
        }
        
        [DataRow("7 días")]
        [DataTestMethod]
        public void TestMethod_Ascii_Data(string input)
        {
            Assert.AreEqual("7 días", input);
        }
    }
}
