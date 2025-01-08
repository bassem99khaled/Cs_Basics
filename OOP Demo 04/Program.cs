﻿using OOP_Demo_04.Interface_Example_01;
using OOP_Demo_04.InterFace_Example_02;
using OOP_Demo_04.InterFace_Example_03;
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

        }
    }
}
