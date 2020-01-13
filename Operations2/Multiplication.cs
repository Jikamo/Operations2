using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Multiplication
    {
        public static int Product(int a, int b)
        {
            return a * b;
        }

        public static double Product(double a, double b)
        {
            return a * b;
        }

        public static double Product(double[] a)
        {
            double c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Product(c, a[i]);
            }
            return c;
        }

        public static int Product(int[] a)
        {
            int c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Product(c, a[i]);
            }
            return c;
        }

    }
}
