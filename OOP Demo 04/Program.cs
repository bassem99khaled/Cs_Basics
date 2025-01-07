using OOP_Demo_04.Interface_Example_01;
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

        }
    }
}
