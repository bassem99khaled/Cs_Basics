using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Operators_Overloading
{
    internal class Complex
    {

        public int Real { get; set; }

        public int Imag { get; set; }



        #region Opperators OverLoading
        // OverLoading Operators ; must be Non-Private Class Member Function

        #region Binary Operators
        public static Complex operator +(Complex left, Complex Right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (Right?.Imag ?? 0),
            };
            // left?.Real
            // Left != Null ? left.Real : null
        }

        public static Complex operator -(Complex left, Complex Right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (Right?.Imag ?? 0),
            };
        }

        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        #endregion
        public override string ToString()
        {
            return $"{Real} + {Imag}";
        }

        #region Comparison Operators [realational ]
        public static bool operator >(Complex left, Complex Right)
        {
            if (left?.Real == Right?.Real)
                return left?.Imag > Right?.Imag;
            else
                return left?.Real > Right?.Real;

        }
        public static bool operator < (Complex left , Complex Right)
        {
            if (left?.Real == Right?.Real) 
                  return left?.Imag < Right?.Imag;  
            else
                 return left?.Real < Right?.Real;

        }

        #endregion

        #region Casting Operators OverLoading

        // OverLoading Casting Operator : Create Non-Private Class Member Function

        public static /*int*/ explicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }

        public static /*string*/  implicit operator string(Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }

        #endregion

        #endregion

    }
}
