using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareTests
    {
        private readonly int a = 6;
        private readonly double c = 6.7;
        private readonly double[] e = { 2.2, 5.5, 5.3 };
        private readonly int[] f = { 2, 5, 10 };

        [TestMethod()]
        public void SquaredTest()
        {
            Assert.AreEqual(36, Square.Squared(a));
        }

        [TestMethod()]
        public void SquaredDoubleTest()
        {
            Assert.AreEqual(44.89, Square.Squared(c));
        }

        [TestMethod()]
        public void SquaredDoubleArrayTest()
        {
            double[] y = Square.Squared(e);
            int i = 0;

            foreach (double w in y)
            {
                Assert.AreEqual(Square.Squared(e[i]), w);
                i++;
            }
        }
    }
}