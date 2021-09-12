using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ConsoleApp;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", ConsoleApp.Program.createmsg());
        }
    }
}
