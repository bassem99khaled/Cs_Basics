using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Operators_Overloading
{
    internal class Complex
    {

        public int Real { get ; set; }

        public int Imag { get; set; }



        #region Opperators OverLoading
        // OverLoading Operators ; must be Non-Private Class Member Function

        #region Binary Operators
        public static Complex operator + (Complex left , Complex Right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) + (Right?.Real ?? 0) ,
                Imag = (left?.Imag ?? 0) + (Right?.Imag ?? 0),
            };
            // left?.Real
            // Left != Null ? left.Real : null
        }

        public static Complex operator - (Complex left, Complex Right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (Right?.Imag ?? 0),
            };

        #endregion
        public override string ToString()
        {
            return $"{Real} + {Imag}";
        }
    }
}
