using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using OOP_Assignment_05.Project_01;
using OOP_Assignment_05.Project_02;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOP_Assignment_05.Project_03;
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

            #region Third Project:
            //            You are tasked with designing a system for an e-commerce platform
            //            that calculates discounts for different types of users and products.
            //            This system should utilize abstraction and include the following parts:


            //            Part 1: Abstract Discount Class
            //            1.Create an abstract class Discount with:
            //o An abstract method CalculateDiscount(decimal price, int quantity)
            //that returns the discount amount based on the original price and quantity.
            //o   A Name property to store the type of discount.
            //Part 2: Specific Discounts
            //2.	Implement the following concrete discount classes:
            //o PercentageDiscount:
            //	Accepts a percentage (e.g., 10%).
            //	Formula: Discount Amount = Price×Quantity×(Percentage/100)
            //o FlatDiscount:
            //	Accepts a fixed amount to be deducted(e.g., $50).
            //	Formula: Discount Amount = Flat Amount×min(Quantity, 1)
            //o   BuyOneGetOneDiscount:
            //	Applies a 50 % discount if the quantity is greater than 1.
            //	Formula: Discount Amount = (Price / 2)×(Quantity÷2)
            //Part 3: Discount Applicability
            //3.Create an abstract class User with:
            //o A Name property to store the user name.
            //o An abstract method GetDiscount() that returns a Discount object.
            //4.	Implement the following specific user types:
            //o RegularUser: Applies a PercentageDiscount of 5%.
            //o PremiumUser: Applies a FlatDiscount of $100.
            //o GuestUser: No discount is applied
            //Part 4: Integration
            //5.	Write a program that:
            //o Ask  the user to input their type(Regular, Premium, or Guest).
            //o Allows the user to input product details(price and quantity).
            //o Calculates and displays the total discount and final price after applying the appropriate discount.



      
            //    Console.WriteLine("Welcome to the E-Commerce Discount System!");

                
            //    Console.Write("Enter your user type (Regular, Premium, Guest): ");
            //    string userType = Console.ReadLine().Trim().ToLower();

            //    Console.Write("Enter your name: ");
            //    string userName = Console.ReadLine();

            //    User user;

                
            //    switch (userType)
            //    {
            //        case "regular":
            //            user = new RegularUser(userName);
            //            break;
            //        case "premium":
            //            user = new PremiumUser(userName);
            //            break;
            //        case "guest":
            //            user = new GuestUser(userName);
            //            break;
            //        default:
            //            Console.WriteLine("Invalid user type. Defaulting to Guest User.");
            //            user = new GuestUser(userName);
            //            break;
            //    }

              
            //    decimal price = ReadDecimalInput("Enter product price: ");
            //    int quantity = ReadIntInput("Enter product quantity: ");

               
            //    Discount discount = user.GetDiscount();
            //    decimal discountAmount = discount != null ? discount.CalculateDiscount(price, quantity) : 0;
            //    decimal totalPrice = (price * quantity) - discountAmount;

               
            //    Console.WriteLine($"User: {user.Name} , {userType.ToUpper()}");
            //    Console.WriteLine($"Product Price: ${price}");
            //    Console.WriteLine($"Quantity: {quantity}");

            //    if (discount != null)
            //    {
            //        Console.WriteLine($"Applied Discount: {discount.Name}");
            //        Console.WriteLine($"Discount Amount: ${discountAmount}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Discount Applied.");
            //    }

            //    Console.WriteLine($"Final Price: ${totalPrice}");
            //}

          
            //static decimal ReadDecimalInput(string prompt)
            //{
            //    decimal value;
            //    while (true)
            //    {
            //        Console.Write(prompt);
            //        if (decimal.TryParse(Console.ReadLine(), out value) && value >= 0)
            //            return value;
            //        Console.WriteLine("Invalid input.");
            //    }
            //}

          
            //static int ReadIntInput(string prompt)
            //{
            //    int value;
            //    while (true)
            //    {
            //        Console.Write(prompt);
            //        if (int.TryParse(Console.ReadLine(), out value) && value > 0)
            //            return value;
            //        Console.WriteLine("Invalid input.");
            //    }
          


        #endregion
    }
}
}
