using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class MultiplicationTests
    {
        private readonly int a = 6;
        private readonly int b = 3;
        private readonly double c = 6.7;
        private readonly double d = 3.2;
        private readonly double[] e = { 2, 2.5, 5.3, 1.7 };
        private readonly int[] f = { 2, 1, 5, 1, 10 };

        [TestMethod()]
        public void TimesTest()
        {
            Assert.AreEqual(18, Multiplication.Product(a, b));
        }

        [TestMethod()]
        public void TimesDoubleTest()
        {
            Assert.AreEqual(21.44, Multiplication.Product(c, d));
        }

        [TestMethod()]
        public void TimesDoubleArrayTest()
        {
            Assert.AreEqual(45.05, Multiplication.Product(e));
        }

        [TestMethod()]
        public void TimesIntArrayTest()
        {
            Assert.AreEqual(100, Multiplication.Product(f));
        }
    }
}