using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class Subtraction
    {
        public static int Difference(int a, int b)
        {
            return a - b;
        }

        public static double Difference(double a, double b)
        {
            return a - b;
        }

        public static double Difference(double[] a)
        {
            double c = 0.0;
            foreach (double b in a)
            {
                c = Difference(c, b);
            }
            return c;
        }

        public static int Difference(int[] a)
        {
            int c = 0;
            foreach (int b in a)
            {
                c = Difference(c, b);
            }
            return c;

        }
    }
}
