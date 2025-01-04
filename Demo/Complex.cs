using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        #region Opeartor Overloading
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = Left.Real + Right.Real,
                Imag = Left.Imag + Right.Imag
            };
        }
        #endregion
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        public static bool operator >(Complex left, Complex right)
        {

            if (left.Real == right.Real)
                return left.Imag > right.Imag;
            else
                return left.Real > right.Real;

        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;
            else
                return left.Real < right.Real;

        }

        public static explicit operator int(Complex complex)
        {
            return complex?.Real ?? 0;
        }

        public static implicit operator string(Complex complex)
        {
            return complex?.ToString() ?? String.Empty;
        }

    }
}
