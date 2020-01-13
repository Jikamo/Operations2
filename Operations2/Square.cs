using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Square
    {
        public static int Squared(int a)
        {
            return a * a;
        }

        public static double Squared(double a)
        {
            return a * a;
        }

        public static double[] Squared(double[] a)
        {
            double[] c = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Squared(a[i]);
            }
            return c;
        }

        public static int[] Squared(int[] a)
        {
            int[] c = new int[a.Length]; ;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Squared(a[i]);
            }
            return c;
        }

    }
}
