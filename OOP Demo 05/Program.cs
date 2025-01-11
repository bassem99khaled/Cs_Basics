namespace OOP_Demo_05;

using System.Security.Authentication;
using OOP_Demo_05;
using OOP_Demo_05.Static;

internal class Program
    {
    static void Main(string[] args)
    {
        #region Abstract [ Class , Method , Property ]

        ////Shape shape = new Shape();
        ////shape.CalcArea();


        //Rect rect = new Rect() { Dim01 = 10, Dim02 = 20 };

        //decimal rectArea = rect.CalcArea();

        //Console.WriteLine($" Rect Area = { rectArea}");
        //Console.WriteLine($" Rect Peri = {rectArea}");

        //Square square = new Square(20);

        //decimal squareArea = square.CalcArea();

        //decimal squarePeri = square.Perimeter;

        //Circle circle = new Circle(10);

        //decimal circleArea = circle.CalcArea();
        //decimal circlePeri = circle.Perimeter;

        //Console.WriteLine($" Cicrle Area = {circleArea}");
        //Console.WriteLine($" Rect Peri = {circlePeri}");

        #endregion

        Utility U01 = new Utility(1, 2);

        Console.WriteLine(U01.CmToInch);




    }
    }

