
using System.Drawing;

namespace demo_session_02

{
    internal class Program
    {
        static void main(string[] args)

        {
            #region error types
            #region syntax error - compilation erorr
            // console.writeline("hello");
            //iint x;
            #endregion

            #region RunTime Error
            // int y = 5;
            //int x = 0;
            // console.writeline(y/x);
            #endregion

            #region Logical Error
            //  int A = 10;
            // int B = 5;
            // Console.WriteLine(Sum(A,B));
            #endregion

            #region Warning
            // int x;  // 4 byte
            //Console.WriteLine(x);

            #endregion

            #endregion

            #region Varibale
            // 5
            //int Number = 5;
            #endregion

            #region CTS _ CLS
            // int X; // 4 byte

            //  string Name = "Test"; // 8 byte
            //  Name = "Ali"; // 6 Byte

            #endregion

            #region Value Type

            //int x; // 4 byte
            // int y= 9 ; // 4 byte
            //  y = x;
            // x++; // 5          
            // Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion

            #region Reference Type

            // Point P01;
            // P01 = new Point();


            //  Point P02 = new Point();

            //  P02 = P01;
            //P01.x = 10;
            // Console.WriteLine(P02.x);
            #endregion

            #region Object

          //  Point P01 = new Point();
           // P01.
                object obj01 = new object();
           // obj = 1;
          //  obj = "Hello";
           // object 'A';
           // obj = true;

            object obj02 = new object();
            Console.WriteLine(obj01.GetHashCode());
            Console.WriteLine(obj02.GetHashCode());
            
            obj02 = obj01;
            Console.WriteLine("****************");
            Console.WriteLine(obj02.GetHashCode());
            Console.WriteLine(obj01.GetHashCode());
            #endregion

            #region Fractions and Discard

           // int Num01 = 123345678912;
           // long Num02 = 12345678912;

          //  Duble Num03 = 22.2;
          //  float Num04 = 22.2F;
           // Decimal Num05 = 22.2m;

         //   int Num06 = 1_000_000;
           // Console.WriteLine(Num06);

            #endregion
        }

    }
}