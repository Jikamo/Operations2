using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {
        private readonly int a = 9;
        private readonly double c = 44.89;
        private readonly double[] e = { 9.9, 5.5, 11.11 };
        private readonly int[] f = { 4, 25, 100 };

        [TestMethod()]
        public void RootTest()
        {
            Assert.AreEqual(3, SquareRoot.Root(a));
        }

        [TestMethod()]
        public void RootDoubleTest()
        {
            Assert.AreEqual(6.7, SquareRoot.Root(c));
        }

        [TestMethod()]
        public void RootDoubleArrayTest()
        {
            double[] y = SquareRoot.Root(e);
            int i = 0;

            foreach (double w in y)
            {
                Assert.AreEqual(SquareRoot.Root(e[i]), w);
                i++;
            }
        }
    }
}