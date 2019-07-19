﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section5
{
    [TestClass]
    public class IntegerOperations
    {
        static int number1;
        static int number2;

        [ClassInitialize()]
        public static void IntegerInitialize(TestContext testContext)
        {
            //set the values of the two numbers we'll be using
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15);
        }
        [TestMethod]
        public void Test_Subtraction()
        {
xint difference = number1 - number2;
            Assert.AreEqual(difference, 5);
        }
        [TestMethod]
        public void Test_Multiplication()
        {
            int multi = number1 / number2;
            Assert.AreEqual(multi, 5);
        }
        [TestMethod]
        public void Test_Division()
        {
        }
        [TestMethod]
        public void Test_Modulus()
        {
        }
    }
}
