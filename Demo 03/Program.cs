using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Demo_03.Casting_Operator_OverLoading;
using Demo_03.Polymorphism;

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
                //Complex C1 = new Complex() { Real = 2, Imag = 4 };
                //Complex C2 = new Complex() { Real = 3, Imag = 5 };

                //Complex C3 = ++C1; Console.WriteLine("After ++C1");

                //Console.WriteLine($"C1={C1}");
                //Console.WriteLine($"C3 = {C3}");

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

                #region Casting Operators overlaoding - Business Need [Mapping]

                //User user = new User();
                //     {
                //       Id = 12345
                //       fullName = "Ahmed Nasr"
                //       Email = "Ahmed.nasr@linkedv.com"
                //      password = "P@sswOrd"
                //      securityStmp = Guid.NewGuid()
                //     };

                //     // Mapping
                //     UserViewModel userViewModel = (UserViewModel) user;

                //     Console.WriteLine(userViewModel.Id);
                //     Console.WriteLine(userViewModel.Email);
                //     Console.WriteLine(userViewModel.FName);
                //     Console.WriteLine(userViewModel.LName);
                #endregion
                #endregion



                #region OOP Pillars 3. PolyMorphism 2.Overriding  

                //TypeA typeA = new TypeB(1, 2);
                //    type.A = 11;
                //    type.B = 22;
                //typeA.MyFun01();  // I am Base [Parent]
                //typeA.MyFun02();  // TypeA; A{11}


                //TypeB typeB = new TypeB(1, 2);
                //typeB.A = 11;
                //typeB.B = 22;

                //typeB.MyFun01(); // I am derived{Child]
                //typeB.MyFun02(); // TypeB : A= {11} , B = {22}

                #endregion


                #region What is Binding ?
                //Binding as Behaviour
                // 1. Static Binding
                // 2. Dynamic Binding


                // Referance from parent = Object From Child

                //TypeA RefBase = new TypeB(1, 2);

                //RefBase.A = 11;
                ////refBase.B = 22;
                //RefBase.MyFun01();  // I am Base  [parent]
                // Static Binding [ Early Binding ]
                // Compiler will Bind Function Call Based On Reference not Object
                // At Compilation Time.


                //RefBase.MyFun02();  // TypeB: A = 11 , B = 2
                // Dynamic Binding Method [Late Binding]
                // CLR will Bind function Call Based on Object not reference
                // At Runtime



                //TypeA typeA;
                //typeA = new TypeA(1);
                //typeA = new TypeB(1, 2);
                //typeA = new TypeC (1,2,3);

                //TypeB typeB = (TypeB) typeA;

                //Console.WriteLine(typeB.A);
                //Console.WriteLine(typeB.B);


                #endregion

                #region Binding is a Behaviour


                ///    class Employee
                ///    {



                ///        public int Id { get; set; }
                ///        public string Name { get; set; }

                ///        public int? Age { get; set; }


                ///        public void MyFun01()
                ///        {
                ///            Console.WriteLine($"Employee: Id: {Id}, Name: {Name} , Age = {Age}");
                ///        }

                ///    }

                ///class FullTimeEmployee : Employee 

                ///        { 

                ///            public decimal Salary { get; set; }

                ///            public new void Myfun01()
                ///            {
                ///                Console.WriteLine("I Am Employee");
                ///            }

                ///        public override void MyFun02()
                ///        {
                ///            Console.WriteLine($"FullTime Employee: Id : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}");
                ///        }
                ///        }

                ///    class PartTimeEmployee : Employee

                ///    {
                ///        public decimal HourRate { get; set; }

                ///        public new void MyFun01()
                ///        {
                ///            Console.WriteLine("I am PartTime Employee");
                ///        }

                ///        public override void MyFun02()
                ///        {
                ///            Console.WriteLine($"PartTime Employee Id = {Id} , Name = {Name} , Age = {Age} , Hourrate = {HourRate}");
                ///        }
                ///    }  namespace Demo_03

                ///    class Employee
                ///    {


                ///        public int Id { get; set; }
                ///        public string Name { get; set; }

                ///        public int? Age { get; set; }

                ///        public void MyFun01()
                ///        {
                ///            Console.WriteLine($"Employee: Id: {Id}, Name: {Name} , Age = {Age}");
                ///        }

                ///    }

                ///class FullTimeEmployee : Employee 

                ///        { 

                ///            public decimal Salary { get; set; }

                ///            public new void Myfun01()
                ///            {
                ///                Console.WriteLine("I Am Employee");
                ///            }

                ///        public override void MyFun02()
                ///        {
                ///            Console.WriteLine($"FullTime Employee: Id : {Id} , Name : {Name} , Age : {Age} , Salary : {Salary}");
                ///        }
                ///        }

                ///    class PartTimeEmployee : Employee

                ///    {
                ///        public decimal HourRate { get; set; }

                ///        public new void MyFun01()
                ///        {
                ///            Console.WriteLine("I am PartTime Employee");
                ///        }

                ///        public override void MyFun02()
                ///        {
                ///            Console.WriteLine($"PartTime Employee Id = {Id} , Name = {Name} , Age = {Age} , Hourrate = {HourRate}");
                ///        }
                ///    }



                ///FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
                ///  processEmployee(FullTimeEmployee);


                //    public static void ProcessEmployee(Employee employee) /*employee = new FullTimeEmployee*/
                //{
                //    if (employee is not null)
                //    {

                //        employee.MyFun01();  // I am full time employee
                //        employee.MyFun02();  // fullTime Emplpuee id = 10 , Name = Ahmed , Age = 23 , Salary = 5_000
                //    }
                //}


                //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
                //{

                //    Id = 20,
                //    Name = "Yassin",
                //    Age = 28,
                //    HourRate = 120,
                //};
                //ProcessEmployee(PartTimeEmployee);



                #endregion


                #region More Practice on Binding

                //TypeA typeA = new TypeC(1 , 2,3);
                //typeA.A = 11;
                ////typeA.B = 22;
                ////TypeA.C = 33;

                //typeA.MyFun01(); // Static Binding Method => I am Base [Parent]
                //typeA.MyFun02(); // Dynamic Binded Method => TypeC : A =11 , B = 2 , C = 3


                //TypeB typeB = new TypeC(1, 2, 3);
                //typeB.A = 11;
                //typeB.B = 22;
                ////TypeA.C = 33;

                //typeB.MyFun01(); // Static Binding Method => I am Derived [Child]
                //typeB.MyFun02(); // Dynamic Binded Method => TypeC : A =11 , B = 22 , C  = 3


                //TypeA typeA = new typeE(1, 2, 3, 4, 5); // InDierct Parent
                //TypeB typeB = new typeE(1, 2, 3, 4, 5); // InDierct Parent
                //TypeC typeC = new typeE(1, 2, 3, 4, 5); // InDierct Parent

                //typeA.MyFun02(); // TypeC : A =1 , B=2 , C =3 

                //typeB.MyFun02(); // TypeC : A =1 , B=2 , C =3 

                //typeC.MyFun02(); // TypeC : A =1 , B=2 , C =3 

                //TypeD typeD = new TypeE(1,2,3,4,5); // Dierct parent

                //TypeD.MyFun02(); // TypeE : A =1 ,B =2 , C =3 , D =4 , E = 5

                #endregion
            }
        }
        }
    }
