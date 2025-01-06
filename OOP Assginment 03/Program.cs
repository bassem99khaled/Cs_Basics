using System;

namespace OOP_Assginment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region 1-Write a class named Calculator that contains a method named Add. Overload the Add method to:
            //•	Accept two integers and return their sum.
            //•	Accept three integers and return their sum.
            //•	Accept two doubles and return their sum.


            //Calculator calc = new Calculator();

            //// Test overloaded methods
            //Console.WriteLine("Sum of 2 and 3 (int): " + calc.Add(2, 3)); // Calls Add(int, int)
            //Console.WriteLine("Sum of 1, 2, and 3 (int): " + calc.Add(1, 2, 3)); // Calls Add(int, int, int)
            //Console.WriteLine("Sum of 2.5 and 3.5 (double): " + calc.Add(2.5, 3.5)); // Calls Add(double, double)





            #endregion


            #region 2-Create a class named Rectangle with the following constructors:
            //	A parameterless constructor that sets the width and height to 0.
            //	A constructor that accepts width and height as integers.
            //	A constructor that accepts a single integer and sets both width and height to that value.




            //Rectangle rect1 = new Rectangle(); 
            //Rectangle rect2 = new Rectangle(10, 20); 
            //Rectangle rect3 = new Rectangle(15); 


            //Console.WriteLine("Rectangle 1:");
            //rect1.DisplayDimensions();

            //Console.WriteLine("\nRectangle 2:");
            //rect2.DisplayDimensions();

            //Console.WriteLine("\nRectangle 3:");
            //rect3.DisplayDimensions();


            #endregion


            #region 3-Define a class Complex Number that represents a complex number with real and imaginary parts.
            //Overload the +, - operator to add and subtract two complex numbers.






            //ComplexNumber c1 = new ComplexNumber(3, 4);
            //ComplexNumber c2 = new ComplexNumber(1, -2);


            //ComplexNumber sum = c1 + c2;


            //ComplexNumber difference = c1 - c2;


            //Console.WriteLine($"Complex Num 1: {c1}");
            //Console.WriteLine($"Complex Num 2: {c2}");
            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Difference: {difference}");


            #endregion

            #region 4. 4-Create a base class named Employee with method Work those prints "Employee is working".
            // Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
            // Ensure that the Manager class also calls the Work method of the Employee class within its overridden method.







            //Employee emp = new Employee();
            //emp.Work();


            //Manager mgr = new Manager();
            //mgr.Work();




            #endregion



            #region 5- Create a base class BaseClass with a virtual method DisplayMessage that prints "Message from BaseClass".
            //  Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
            //  Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
            //  And explain the difference between using override and new (using binding behavior)	 





            //BaseClass baseObj = new BaseClass();
            //baseObj.DisplayMessage(); 

            //BaseClass derived1 = new DerivedClass1();
            //derived1.DisplayMessage();


            //BaseClass derived2 = new DerivedClass2();
            //derived2.DisplayMessage();


            //DerivedClass2 derived2Direct = new DerivedClass2();
            //derived2Direct.DisplayMessage(); 


            //            Binding Behavior:

            //override: Supports runtime polymorphism[dynamic binding]. The method call depends on the actual object type, not the reference type.

            //new: [static binding]. The method call depends on the reference type, not the object type.


            #endregion

            #endregion


            #region Part 02


            #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.





            //Duration duration1 = new Duration(1, 120, 360);
            //duration1.DisplayDuration(); 


            //Duration duration2 = new Duration();
            //duration2.DisplayDuration(); 





            #endregion



            #region 2-Override All System. Object Members (To String, Equals,GetHasCode) 






            //Duration duration1 = new Duration(1, 120, 360);
            //Duration duration2 = new Duration(2, 2, 0);


            //Console.WriteLine("Duration 1:");
            //duration1.DisplayDuration();

            //Console.WriteLine("\nDuration 2:");
            //duration2.DisplayDuration();


            //Console.WriteLine(" durations equal? " + duration1.Equals(duration2));


            //Console.WriteLine("HashCode for Duration 1: " + duration1.GetHashCode());
            //Console.WriteLine("HashCode for Duration 2: " + duration2.GetHashCode());


            #endregion


            #region 3-Define All Required Constructors to Produce this output:
            //            Duration D1 = new Duration(1, 10, 15);
            //            D1.ToString();
            //        Output: Hours: 1, Minutes: 10, Seconds: 15
            //Duration D1 = new Duration(3600);
            //            D1.ToString();
            //        Output: Hours: 1, Minutes: 0, Seconds: 0
            //Duration D2 = new Duration(7800);
            //            D2.ToString();
            //        Output: Hours: 2, Minutes: 10, Seconds: 0
            //Duration D3 = new Duration(666);
            //            D3.ToString();
            //        Output: Minutes: 11, Seconds: 6



            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString()); 

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString()); 

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString()); 

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString()); 


            #endregion

            #region  4 - Implement All required Operators overloading to enable this Code:
            //•	D3 = D1 + D2
            //•	D3 = D1 + 7800
            //•	D3 = 666 + D3
            //•	D3 = ++D1(Increase One Minute)
            //•	D3 = --D2(Decrease One Minute)
            //•	D1 = D1 - D2
            //•	If(D1 > D2)
            //•	If(D1 <= D2)
            //•	If(D1)
            //•	DateTime Obj = (DateTime)D1





            //Duration02 D1 = new Duration02(1, 10, 15);
            //Duration02 D2 = new Duration02(7800);
            //Duration02 D3;


            //D3 = D1 + D2;
            //Console.WriteLine("D3 = D1 + D2: " + D3);

            //D3 = D1 + 7800;
            //Console.WriteLine("D3 = D1 + 7800: " + D3);

            //D3 = 666 + D3;
            //Console.WriteLine("D3 = 666 + D3: " + D3);

            //D3 = ++D1;
            //Console.WriteLine("D3 = ++D1: " + D3);

            //D3 = --D2;
            //Console.WriteLine("D3 = --D2: " + D3);

            //D1 = D1 - D2;
            //Console.WriteLine("D1 = D1 - D2: " + D1);

            //if (D1 > D2)
            //    Console.WriteLine("D1 is greater than D2");

            //if (D1 <= D2)
            //    Console.WriteLine("D1 is less than or equal to D2");

            //if (D1)
            //    Console.WriteLine("D1 is non-zero");

            //DateTime obj = (DateTime)D1;
            //Console.WriteLine("DateTime equivalent of D1: " + obj.ToString("HH:mm:ss"));



            #endregion
            #endregion


        }
    }
}
