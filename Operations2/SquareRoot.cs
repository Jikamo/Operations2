using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class SquareRoot
    {
        public static double Root(int a)
        {
            return Math.Pow(a, 1.0 / 2.0); ;
        }

        public static double Root(double a)
        {
            return Math.Pow(a, 1.0 / 2.0);
        }

        public static double[] Root(double[] a)
        {
            double[] c = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Root(a[i]);
            }
            return c;
        }

        public static double[] Root(int[] a)
        {
            double[] c = new double[a.Length]; ;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Root(a[i]);
            }
            return c;
        }
    }
}
