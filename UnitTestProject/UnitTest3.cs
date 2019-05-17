using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/* Initialize Test */
namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Part3")]
    public class UnitTest3
    {
        private int a;
        [TestInitialize]
        public void RunBeforeEveryTest()
        {
            a = 1;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var b = 2;
            Assert.AreEqual(3, a + b);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(a == 1);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            Assert.AreNotEqual(1, 1);
        }
    }
}
