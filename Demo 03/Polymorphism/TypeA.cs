using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Polymorphism
{
    #region OOP Pillars 3. PolyMorphism 2.Overriding
    internal class TypeA
    {
        public int A { get; set; }


        public TypeA(int A)
        {

            this.A = A;
        }

        public void MyFun01()
        {
            Console.WriteLine("MyFun01 => I am Base [Parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"MyFun02 => Type A= {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }


        public TypeB(int A, int B) : base(A)
        {
            this.B = B;
        }


        // 1. Apply Overriding using "New" KeyWord => Hidding / Masking OLD Method --> NEW Method
        public void MyFun01() /* static Binding Method [Early Binding] */
        {
            Console.WriteLine($" MyFun01 => I Am Derived [Child]");
        }


        // 2. Apply Overriding using "Override" Keyword =>Method must be non-private and Virtual in first apperance
        public override void MyFun02()  /*  Dynamic Binding Method [Late Binding] */
        {
            Console.WriteLine($" MyFun02 => TypeB: A = {A} , B = {B}");
        }

        #endregion

    }

    class TypeC : TypeB
    {
        public int C { get; set; }


        public TypeC(int A, int B, int C) : base(A , B)
        {
            this.C = C;
        }

        public void MyFun01()
        {
            Console.WriteLine("I am Derived [GrandChild]");

        }


        public override void MyFun02()
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C}");
        }

    }

    class TypeD : TypeC
    {

        public int D { get; set; }

        public TypeD(int A, int B, int C, int D) : base(A, B, C)
        {
            this.D = D;
        }
        public new void MyFun01()
        {
            Console.WriteLine("");
        }

        public new void MyFun02()
        {
            Console.WriteLine($"TypeC : A = {A} , B = {B} , C = {C} , D = {D}");
        }




    }

    class typeE : TypeD
    {
        public int E { get; set; }

        public typeE(int A, int B, int C, int D, int E) : base(A, B, C, D)
        {
            this.E = E;
        }

        public new void MyFun02()
        {
            Console.WriteLine($"TypeE : A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");

        }

    
    
    }
}