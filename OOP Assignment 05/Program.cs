using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using OOP_Assignment_05.Project_01;
using OOP_Assignment_05.Project_02;

namespace OOP_Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Define 3D Point Class and the basic Constructors (use chaining in constructors).
            //     2 - Override the ToString Function to produce this output:
            //     Point3D P = new Point3D(10, 10, 10);
            //     Console.WriteLine(P.ToString());
            //     Output: “Point Coordinates: (10, 10, 10)”.
            //   3 - Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert).

            //   4 - Try to use ==
            //   If(P1 == P2)   Does it work properly? 
            //   5 - Define an array of points and sort this array based on X &Y coordinates.
            //   6 - Implement ICloneable interface to be able to clone the object.
            //   To implement more than one interface.
            //   class Point3D : IComparable, ICloneable





            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());


            //Point3D P1 = ReadPointFromUser("P1");
            //Point3D P2 = ReadPointFromUser("P2");


            //if (P1 == P2)
            //    Console.WriteLine("P1 and P2 are equal.");
            //else
            //    Console.WriteLine("P1 and P2 are not equal.");



            //Point3D[] pointsArray = {
            //new Point3D(3, 5, 1),
            //new Point3D(1, 2, 3),
            //new Point3D(3, 2, 4),
            //new Point3D(1, 2, 2)
            //    };

            //Array.Sort(pointsArray);

            //Console.WriteLine("\nSorted Points:");
            //foreach (var point in pointsArray)
            //{
            //    Console.WriteLine(point);
            //}




            //Point3D clonedPoint = (Point3D)P1.Clone();
            //Console.WriteLine($"\nCloned Point: {clonedPoint}");
            // }



            //static Point3D ReadPointFromUser(string pointName)
            //{
            //    int x, y, z;

            //    Console.WriteLine($"\nEnter coordinates for {pointName}:");

            //    x = ReadCoordinate("X");
            //    y = ReadCoordinate("Y");
            //    z = ReadCoordinate("Z");

            //    return new Point3D(x, y, z);
            //}




            //static int ReadCoordinate(string coordinateName)
            //{
            //    int value;
            //    while (true)
            //    {
            //        Console.Write($"Enter {coordinateName}: ");
            //        string input = Console.ReadLine();

            //        if (int.TryParse(input, out value))
            //            break;
            //        else
            //            Console.WriteLine("Invalid input. Please enter an integer.");
            //    }
            //    return value;





            #endregion

            #region Second Project:
            //      Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters.Call each method in Main().
            //    Modify the program so that you do not have to create an instance of class to call the four methods.

         
      

        
               // double num1 = 10;
               // double num2 = 5;

             
               // Console.WriteLine($"Addition: {Maths.Add(num1, num2)}");         // Output: 15
               // Console.WriteLine($"Subtraction: {Maths.Subtract(num1, num2)}"); // Output: 5
               // Console.WriteLine($"Multiplication: {Maths.Multiply(num1, num2)}"); // Output: 50
               // Console.WriteLine($"Division: {Maths.Divide(num1, num2)}");      // Output: 2

               //// testing the error
               // Console.WriteLine($"Division by Zero: {Maths.Divide(num1, 0)}"); 
          



        #endregion
    }
}
}
