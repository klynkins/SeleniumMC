using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class FloatingPointOperations
    {
        static double number1;
        static double number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void Test_Addition()
        {
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5);
        }
        [TestMethod]
        public void Test_Subtraction()
        {
            double difference = number1 - number2;
            Assert.AreEqual(difference, 5.5);
        }
        [TestMethod]
        public void Test_Multiplication()
        {
            double multi = number1 * number2;
            Assert.AreEqual(multi, 52.5);
        }
        [TestMethod]
        public void Test_Division()
        {
            double div = number1 / number2;
            Assert.AreEqual(div, 2.1);
        }
        [TestMethod]
        public void Test_Modulus()
        {
            double mod = number1 % number2;
            Assert.AreEqual(mod, 0.5);
        }
    }
}
