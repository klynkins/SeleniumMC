using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    // 1. All tests should have to be categorized as Quiz
    // 2. 3 test methods
    // 3. one test checks that 1 + 1 =2
    // 4. one test automatically fails using a special assertion method
    // 5. one test that checks that 10 + 10 = 21 and expects the tests to fail

    [TestClass]
    [TestCategory("Quiz")]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.Fail("This test will always fail");
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}
