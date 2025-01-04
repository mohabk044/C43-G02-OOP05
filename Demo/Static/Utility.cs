using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal static class Utility
    {
        public static double CmInch(double cm)
        {
            return cm / 2.54;
        }

        //private static double pi = 3.14;
        private const double pi = 3.14;

        public static double Pi
        {
            get { return pi; }
        }

        public static double AreaCircle(double redius)
        {
            return redius * redius * Pi;
        }
    }
}