using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First_Project
{
    internal static class Maths
    {
        #region Test
        //public Maths(int num1, int num2)
        //{
        //    Num1 = num1;
        //    Num2 = num2;
        //}

        //public int Num1 { get; set; }
        //public int Num2 { get; set; }

        //public int Sum()
        //{
        //    return Num1 + Num2;
        //}
        //public int Subtract()
        //{
        //    return Num1 - Num2;
        //}
        //public int Multiply()
        //{
        //    return Num1 * Num2;
        //}
        //public int Divided()
        //{
        //    return Num1 / Num2;
        //} 
        #endregion

        public static int Sum(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public static int Subtract(int Num1, int Num2)
        {
            return Num1 - Num2;
        }
        public static int Multiply(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
        public static double Divided(double Num1, double Num2)
        {
            if (Num2 != 0)
                return Num1 / Num2;
            Console.Write("Error! Cannot Divided By Zero ");
            return 0;
        }
    }
}