using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_05
{
    // Abstract Class
    // is a Partial Implementation for Other Classes.
    // is a Container for Comman Code [ Fully Implemented Menbers , Abstract Member ] among many Classes.
    // you Cant Create an object from abstract class [ it is not full implementated]
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        // Abstract Property = Virtual Property Without Implmentation
        public abstract decimal Perimeter { get; }

        // abstract method = Virtual method without Implmentation
        public abstract decimal CalcArea();

        protected Shape(decimal Dim01,decimal Dim02)
        {
this.Dim01 = Dim01;
            this.Dim02 = Dim02;
        }
    }
    

    abstract class  RectBase : Shape

    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    // Concrete Class
    // class Rect : Shape
    //{
    //    public override decimal Perimeter
    //    {
    //        get { return (Dim01 + Dim02) * 2; }
    //    }
    //    public override decimal CalcArea()
    //    {
    //        return Dim01 * Dim02;
    //    }
    //}

    //class Parent
    //{

    //    public virtual int Salary {
    //        get { return Salary; }
    //        set { Salary = value < 5000 ? 5000 : value; }
    //    }

    //    public virtual void Print()
    //    {
    //        Console.WriteLine("Iam Parent");
    //    }

    //    class Child : Parent
    //    {
    //        public override int Salary
    //        {
    //            get { return base.Salary; }
    //            set { base.Salary = value + 2000; }

    //        }

    //        public override void Print()
    //        {
    //            Console.WriteLine("I Am Child");
    //        }

    //    }
    //}


    // Concrete Clas
    class Square : RectBase
    {

        public Square(int Dim)
        {

            this.Dim01 = this.Dim02 = Dim;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }

        //Concrete Class
        class Cicle : Shape //, IDraw3D , IDraw2D
        {
            public Cicle(decimal Radius)
            {
                this.Dim01 = this.Dim02 = Radius;
            }
            public override decimal Perimeter 
               {
                get { return 2 * 3.14M * this.Dim01; }
            }

            public override decimal CalcArea()
            {
                return 3.14M * this.Dim01 * this.Dim02;
            }
        }

        class Triangle : Shape
        {

            public decimal Dim03 { get; set; }

            public override decimal Perimeter => throw new NotImplementedException();

            public Triangle(decimal Dim01, int Dim02, int Din03) : base(Dim01 ,Dim02)
            {
                this.Dim01 = Dim01;
                this.Dim02 = Dim02;
                this.Dim03 = Din03;
            }
            private interface IDraw2D
            {

            }

            interface IDraw3D
            {
            }

            public override decimal CalcArea()
            {
                throw new NotImplementedException();
            }

        }
    }
}
