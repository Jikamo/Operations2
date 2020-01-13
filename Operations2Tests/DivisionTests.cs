using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        private readonly int a = 10;
        private readonly int b = 5;
        private readonly int z = 0;
        private readonly double c = 10.5;
        private readonly double d = 3.5;
        private readonly double[] e = { 45.05, 1.7, 5.3, 2.5 };
        private readonly int[] f = { 1000, 10, 5, 2 };

        [TestMethod()]
        public void QuotientTest()
        {
            Assert.AreEqual(2, Division.Quotient(a, b));
        }

        [TestMethod()]
        public void QuotientDoubleTest()
        {
            Assert.AreEqual(3, Division.Quotient(c, d));
        }

        [TestMethod()]
        public void QuotientDoubleArrayTest()
        {
            Assert.AreEqual(2, Division.Quotient(e));
        }

        [TestMethod()]
        public void QuotientIntArrayTest()
        {
            Assert.AreEqual(10, Division.Quotient(f));
        }

        [TestMethod()]
        public void QuotientIntDivideZeroTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.Quotient(a, z));
        }
    }
}