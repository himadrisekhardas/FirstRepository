using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using HelloAppCore3;

namespace HelloAppCore3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", HelloAppCore3.Program.CreateMsg());
        }
    }
}
