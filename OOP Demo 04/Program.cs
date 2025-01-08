using OOP_Demo_04.Interface_Example_01;
using OOP_Demo_04.InterFace_Example_02;
using OOP_Demo_04.InterFace_Example_03;
using OOP_Demo_04.Built_in_InterFace;
using System.Net.Http.Headers;
namespace OOP_Demo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Interface_Example_01
            //IType reference;

            //// Declare for Refence of Type "IType" , Containg Garbag Value
            //// this Reference 'type' Can Refer to an Object of any "Type Implementing Itype InterFace"
            ////  CLR will Allocate 4 UnInitialized Bytes in Stack For this Reference
            ////  CLW will Allocate 0 Byte in Heap.

            //// reference = /*new IType()*/   --> INVALID 

            //reference = new TypeA();
            //reference.MyProperty = 10;
            //reference.MyMethod(); // Hello World
            //reference.Print();  // Default Implemented method

            //TypeA typeA = new TypeA();
            //reference.MyProperty = 10;
            //reference.MyMethod();
            //reference.Print();
            #endregion

            #region Interface_Example_02


            //static void PrintTenNumbersFromSeries(Iseries series)

            //{
            //    if (series is not null)
            //        return;

            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.Write($"{series.Current}\t");
            //        series.GetNext();
            //    }
            //    series.Reset();
            //    Console.WriteLine();
            //}

            //InterFace_Example_02.TypeA seriesByTwo = new InterFace_Example_02.TypeA();
            //PrintTenNumbersFromSeries(seriesByTwo);

            //TypeB seriesByThree = new TypeB();
            //PrintTenNumbersFromSeries(seriesByThree);

            //TypeC seriesByFour = new TypeC();
            //PrintTenNumbersFromSeries(seriesByFour);

            #endregion

            #region InterFace_exmaple_03

            // AirPlane airplane = new AirPlane();
            //airplane.Speed = 400;
            ////airplane.Forward();

            //ImoveAble moveable = airplane;
            //moveable.Forward();

            //IFlyAble flyable = airplane;
            //flyable.Forward();


            #endregion

            #region Shallow Copy Vs Deep Copy

            #region Shallow Copy

            //int[] arr01 = [1, 2 , 3];
            //int[] arr02 = {4 , 5, 6};

            //Console.WriteLine($"arr01.GetHashCode = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr01.GetHashCode = {arr02 .GetHashCode()}");



            //arr02 = arr01; Console.WriteLine("After shadow Copy ------ >");

            //arr02 = (int[])arr01.Clone(); Console.WriteLine("Deep Copy --> Arr02 = (int[]) Arr01");

            // Clone Method : will Genrate New Object With New and DIFFERENT Identity 
            //              : This Object will have the same State [Data] of the Caller Object

            #endregion


            ///Shallow Copy
            /// this Object [ 1 , 2 , 3 ] Has 2 Reference [Arr01 , Arr02] (اسمين دلع ).
            /// this object [ 4 , 5, 6 ] Became UnReachable Object.
            /// Shallow Copy تاثير سطحي


            #region Deep Copy
            //Console.WriteLine($"arr01.GetHashCode = {arr01.GetHashCode()}");
            //Console.WriteLine($"arr01.GetHashCode = {arr02.GetHashCode()}");

            //arr02[0] = 100;




            //Console.WriteLine("----------------------");
            //foreach (int number in arr01)
            //    Console.WriteLine(number);
            //Console.WriteLine("*************");
            //foreach (int number in arr01)
            //    Console.WriteLine(number);

            #endregion


            #endregion

            #region Why Clone Method Description Says Makes A shallow copy ?


            //string[] Name01 = ["Amr", "Mona"];
            //string[] Name02 = ["Ahmed", "Yassmin"];

            //Console.WriteLine($"Name01.GetHashCode() = {Name01.GetHashCode()}");

            //Console.WriteLine($"Name02.GetHashCode() = {Name02.GetHashCode()}");

            //Name02 = (string[])Name01.Clone(); Console.WriteLine("After Deep Copy --> Names02= (sting[])Name01.Colne  ");
            ////Clone Method : will Genrate New Object with New and Different Identity
            ////              : This Object will have the same state [data] of the original object [shallow copy]


            //Console.WriteLine($"Name01.GetHashCode() = {Name01.GetHashCode()}");

            //Console.WriteLine($"Name02.GetHashCode() = {Name02.GetHashCode()}");

            //Name02[0] = new string ("Khaled");

            //Console.WriteLine (Name01[0]); // Amr
            #endregion

            #region ICloneable 

            //Employee employee01 = new Employee() { Id = 10, Name = " Ahmed", Salary = 8_000, department = new Department() { Code = 1001, Title = " Salary" } };
            //Employee employee02 = new Employee() { Id = 20, Name = "Osama", Salary = 5_000, department = new Department() { Code = 2002, Title = "HR" } };

            //     Console.WriteLine($"employee01.GetHashCode() = {employee01.GetHashCode}");
            //     Console.WriteLine($"employee02.GetHashCode() = {employee02.GetHashCode}");

            //     employee02 = (Employee)employee02.Clone(); // Deep copy using Clone

            //// Clone Method : this Method Generates New Object with New And Different Identity 
            ////              : this object will habe the same state [Data] of the Caller Object

            //Employee02 = new Employee(employee01);


            //if(employee02.department is not null)
            //employee02.department.Title = " new";

            //     Console.WriteLine("After Deep Copy");

            //     Console.WriteLine($"employee01.GetHashCode() = {employee01.GetHashCode}");
            //     Console.WriteLine($"employee02.GetHashCode() = {employee02.GetHashCode}");


            //     Console.WriteLine("**********************");


            //     Console.WriteLine($"Employee01 = {employee01}");
            //     Console.WriteLine($"Employee02 = {employee02}");
            #endregion

            #region ICompareable & IComparer

           // int[] Number = [9, 3, 1, 2, 5, 6, 7, 8, 43, 5];

           // Array.Sort(Number);

           // foreach (int number in Number)
           // {
           //     Console.WriteLine(number);
           // }


           // Employee[] employees = {
           //    new Employee() { Id = 10 , Name = "Ahmed" , Salary = 8_000},
           //    new Employee() { Id = 20 , Name = "Omar" , Salary = 5_000},
           //    new Employee() { Id = 30 , Name = "Samir" , Salary = 6_000},
           //    new Employee() { Id = 40 , Name = "Bassem" , Salary = 3_000},
           // };

           // Array.Sort(employees , new EmployeeComparer());

           //// int Result = employees[0].CompareTo("Hamada");


           // foreach (Employee employee in employees) 
           // Console.WriteLine(employees);

            #endregion



        }
    }
}
