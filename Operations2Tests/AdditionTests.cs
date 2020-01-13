using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly Random rnd = new Random();
        private readonly double[] e = { 3, 3.1, 6.3, 2.7 };
        private readonly int[] f = { 3, 4, 6, 5, 11 };
        [TestMethod()]
        public void SumTest()
        {
            int a = rnd.Next();
            int b = rnd.Next();
            Assert.AreEqual(a + b, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumTestdouble()
        {
            double a = rnd.NextDouble();
            double b = rnd.NextDouble();
            Assert.AreEqual(a + b, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumTestdoublearray()
        {
            Assert.AreEqual(e[0] + e[1] + e[2] + e[3], Addition.Sum(e));
        }

        [TestMethod()]
        public void SumIntArray()
        {
            Assert.AreEqual(29, Addition.Sum(f));
        }
    }
}