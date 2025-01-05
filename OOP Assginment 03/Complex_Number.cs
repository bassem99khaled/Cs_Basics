using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assginment_03
{
    internal class ComplexNumber
    {

        #region Parameters
        public double Real { get; set; }
        public double Imaginary { get; set; }

        #endregion

        #region Constructors

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }


        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }
        #endregion

        #region Method
        public override string ToString()
        {
            string sign = Imaginary >= 0 ? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }

       
        #endregion
    }
}
