using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class DecimalOperations
    {
        static decimal number1;
        static decimal number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5M;
            number2 = 5.0M;
        }

        [TestMethod]
        public void Test_Addition()
        {
            decimal sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5M);
        }
        [TestMethod]
        public void Test_Subtraction()
        {
            decimal difference = number1 - number2;
            Assert.AreEqual(difference, 5.5M);
        }
        [TestMethod]
        public void Test_Multiplication()
        {
            decimal multi = number1 * number2;
            Assert.AreEqual(multi, 52.5M);
        }
        [TestMethod]
        public void Test_Division()
        {
            decimal div = number1 / number2;
            Assert.AreEqual(div, 2.1M);
        }
        [TestMethod]
        public void Test_Modulus()
        {
            decimal mod = number1 % number2;
            Assert.AreEqual(mod, 0.5M);
        }
    }
}
