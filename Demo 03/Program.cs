using System.Numerics;
namespace Demo_03.Operators_Overloading
{

    namespace Demo_03
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                #region Operators OverLoading
                #region OverLoading

                // static int Sum02Numbers(int X , int Y)
                // {
                //     return X + Y;
                // }

                // static int sum ( int X , int Y , int Z)
                // {
                //     return X +Y + Z;
                // }

                // static double Sum( double X , double Y )
                // {
                //     return X * Y;
                // }

                //static double Sum( int x , double y)
                // {
                //     return x + y;
                // }
                // dynamic Obj = "Ahmed";  // Dynamic like Var in java script
                //                             // dynamic make load in run time not use every time
                // Obj = 10;

                // Obj = true;

                // dynamic Result = Sum02Numbers ( 1 , 2 );

                // Console.WriteLine( $" Result {Result}" );

                // Console.WriteLine("Ahmed");
                // Console.WriteLine("A");
                // Console.WriteLine(10);
                // Console.WriteLine(true);

                #endregion

                #region Binary Operators 

                //Complex C1 = new Complex() { Real = 2, Imag = 4 };
                //Complex C2 = new Complex() { Real = 3, Imag = 5 };

                //Complex C3 = default; // Null



                //C3 = C1 + C2;

                //Complex C4 = C1 + C2 + C3;

                //Console.WriteLine($"C1 = {C1}");
                //Console.WriteLine($"C2 = {C2}");
                //Console.WriteLine("______________________");
                //Console.WriteLine($" C3 = {C3}");
                #endregion

                #region Unary Operators
                Complex C1 = new Complex() { Real = 2, Imag = 4 };
                Complex C2 = new Complex() { Real = 3, Imag = 5 };

                Complex C3 = ++C1; Console.WriteLine("After ++C1");

                Console.WriteLine($"C1={C1}");
                Console.WriteLine($"C3 = {C3}");

                #endregion

                #region Comparison Operators [realational ]

                //if (C1 > C2)

                //    Console.WriteLine("C1 is Greater than C2");
                //else if (C1 < C2)
                //    Console.WriteLine("C1 is  Less than C2");
                //else
                //    Console.WriteLine("C1 Equal C2");
                #endregion


                #region Casting Operator Overloading
                #region Example 01

                //Complex C1 = new Complex() { Real = 4 , Imag = 5 };

                //int Y = (int) C1; // Explicit Casting


                //Console.WriteLine($"Y = {Y}");

                //object O1 = 5;

                //int X = (int) O1;

                //Console.WriteLine(X);

                #endregion

                #region Example 02

                //Complex C1 = new Complex() {  Real = 4 , Imag = 5 };

                //string Y = /*{String}*/ C1; // implicit Casting

                //Console.WriteLine($"Y = {Y}");


                //Object O1 = "Ahmed";

                //string X = (string)O1;
                
                //Console.WriteLine(X);

                #endregion
                #endregion
                #endregion
            }
        }
    }
}
