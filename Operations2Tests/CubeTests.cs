using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Tests
{
    [TestClass()]
    public class CubeTests
    {
        private readonly int a = 3;
        private readonly double c = 2.5;
        private readonly double[] e = { 2.2, 5.5, 5.3 };
        private readonly int[] f = { 2, 5, 10 };

        [TestMethod()]
        public void CubedTest()
        {
            Assert.AreEqual(27, Cube.Cubed(a));
        }

        [TestMethod()]
        public void CubedDoubleTest()
        {
            Assert.AreEqual(15.625, Cube.Cubed(c));
        }

        [TestMethod()]
        public void CubedDoubleArrayTest()
        {
            double[] y = Cube.Cubed(e);
            int i = 0;

            foreach (double w in y)
            {
                Assert.AreEqual(Cube.Cubed(e[i]), w);
                i++;
            }
        }

        [TestMethod()]
        public void CubedIntArrayTest()
        {
            int[] d = Cube.Cubed(f);
            int i = 0;

            foreach (int z in d)
            {
                Assert.AreEqual(Cube.Cubed(f[i]), z);
                i++;
            }
        }
    }
}