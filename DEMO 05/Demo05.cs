using System.Security.Authentication;

namespace DEMO_05
{

    // Class
    // interface
    // enum
    // struct
    internal class Demo05
    {

        //Function
        // Data

        // types of function
        // 1. class member function [static function]
        // 2. object member function [non static function]


        // print (*-*)

        public static void PrintShape(int count = 10 , string pattern = "*-*")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern);
            }
        }

        public static void Swap( ref int X ,ref  int Y )
        {
            int temp = X;
            X = Y;
            Y = temp;
        }


        public static int SumArray(int x , params int[] arr )
        {

            // sum +1 =1
            // 1+2 = 3
            // 3+3=6
            int sum = 0;
          //arr = new int[] { 4, 5, 6};
            //arr[0] = 100 ;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }


        public static void SumMul(int x , int y , ref int Sum , ref int Mul)
        {
             Sum = x + y;
             Mul = x * y;
            //return sum;
            //return mul;

        }
        static void Main(string[] args)
        {
            #region Casting [ Boxing - Unboxing ]

            // refernce type Casting => Convert from Reference to to refernce type
            // Boxing Casting => Convert from value type to reference type
            // unboxing casting => convert from erefernce type to value type

            //object obj = new object();
            //obj = "Mostafa"; // refernce type casting
            //obj = 2; //boxing casting from value type [int] to reference type [ object]

            #region Boxing [ Safe Code ]

            //int x = 10;
            //object obj01 = new object();
            //obj01 = x;

            //Console.WriteLine(obj01);
            //parent = child
            // Dog is animal
            #endregion

            #region Unboxing [ Unsafe Code ]

            //object obj02 = new object();
            //obj02 = 10;
            //int x = (int)obj02;
            //Console.WriteLine(x);
            //child = parent
            // anilmal is Dogs
            #endregion

            #endregion

            #region Nullable Data Type
            #region Value type

            ////int x = null // int numbrt only

            //int? x = null; //int number and null

            //Console.WriteLine(x);

            //int x = 10;
            //int? y = x; //Accepted


            //int? x = 10;
            //int y = (int)x; //not accepted because cant convert null to int 

            //int? x = null;
            //int y;
            //if (x != null)
            //{
            //    y = (int)x; //casting
            //}
            //else {
            //    y = 0;
            //     }

            //Console.WriteLine(y);

            //if (x.hasvalue)
            //{
            //    yield = x.value;  // not casting using in work **** 

            //}
            //else
            //{
            //    y = 0;
            //}

            //y = x.HasValue ? X.Value : 0;


            #endregion

            #region Reference Type

            //string? Name = null;

            //Console.WriteLine(Name);




            #endregion

            #endregion

            #region Null Propagation Operator

            //int[] Number = null;

            //for (int i = 0; Number!=null && i < Number.Length; i++) // not using in real
            //    {
            //        Console.WriteLine(Number[i]);
            //    }


            //for (int i = 0;  i < Number?.Length; i++) //  not using in real 
            //    {
            //        Console.WriteLine(Number[i]);
            //    }


            //if (Number != null) // using in real because one check only in first not looping
            //{

            //    for (int i = 0; i < Number.Length; i++) 
            //    {
            //        Console.WriteLine(Number[i]);
            //    }
            //}



            // i < Numbers?.Length
            // Numbers => Object [ Length ]
            // Numbers => Null [ Null ]


            //int lenghth = Number?.Length ?? 0;  

            //Console.WriteLine(lenghth);


            //employee emp = new employee();

            //emp.Department = new Department();

            ////if (emp != null)
            //{
            //    if (emp.Department != null)
            //    {
            //        Console.WriteLine(emp.Department.Name);
            //    }
            //}
            //Console.WriteLine(emp?.Department.Name?? "Not Found");
            #endregion

            #region Funcations

            //PrintShape(10 , "*-*");
            //PrintShape ( pattern: "*-*" , count: 10)
            //PrintShape();

            // Hello Mostafa 
            // Welcome to Route

            //Console.WriteLine("Hello Mostafa\n Welcome To\tRoute");
            //PrintShape(@"/*\\", 10); // add @ or make duble \\ to scape meaning



            #endregion

            #region Value Type Paramters

            #region By Value

            //int A = 5;
            //int B = 9;
            //Console.WriteLine(B);
            //Console.WriteLine(A);

            //Swap(A, B);

            //Console.WriteLine(B);
            //Console.WriteLine(A);

            #endregion
            #region By Reference

            //int A = 5;
            //int B = 9;
            //Console.WriteLine(B);
            //Console.WriteLine(A);

            //Swap(ref A, ref B);

            //Console.WriteLine(B);
            //Console.WriteLine(A);

            #endregion

            #endregion


            #region Reference Type
            #region Ex01
            #region By Value
            //int[] Number = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Number));
            //Console.WriteLine(Number[0]);


            #endregion

            #region By reference

            //int[] Number = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Number));
            //Console.WriteLine(Number[0]);

            #endregion
            #endregion

            #region Ex02
            #region  By Value

            //int[] Number = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Number));
            //Console.WriteLine(Number[0]);

            #endregion
            #region By ref
            //int[] Number = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Number));
            //Console.WriteLine(Number[0]);

            #endregion
            #endregion

            #endregion

            #region Functions - passing by out

            //int A = 10;
            //int B = 20;
            //int Sum, Mul;
            //SumMul(A, B, ref Sum, ref Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);

            #endregion

            #region Functions - Params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SumArray({ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});


            //int A = 10 , B = 20 , C = 30;
            //Console.WriteLine("A : {0} , B: {1} , C: {2}", A , B , C);
        

            #endregion
        }
    }
}
