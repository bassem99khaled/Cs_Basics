using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_02
{
    internal struct Point
    {

        #region Fields
        // Attributes (Private)

        private int x;
        private int y;

        #endregion

        // Constructor : is a special function
        //    1. Named always with the same name of its class or struct
        //    2. Has no Return

        /// in struct , copiler will always generate Empty "parameterless constructor"
        /// this constructor will initialize each and every struct object attribute with its default value

        #region Constructor
        //public Point(int x, int y)
        //{

        //    this.x = defualt;
        //    this.y = defualt;

        //}
        //public Point(int x, int y)
        //{

        //    this.x = x;
        //    this.y = y;

        //}

        //public Point(int number)
        //{
        //    this.x = this.y = number;
        //}   // 3 constructor that Name constructor overloading

        #endregion

        #region Methods
        //public Point(int x, int y)
        //{

        //    this.x = x;
        //    this.y = y;

        //}

        //public override string ToString()
        //{
        //    return $"({x} , {y})";
        //}
        #endregion
    }
}
