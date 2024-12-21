using System;
using System.Runtime.InteropServices;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Write a program that allows the user to enter a number then print it.


            Console.Write("Please enter a number: ");

            int Number;

            Console.WriteLine("You entered: " + Number);

            #endregion

            #region Q2-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            int Num1 = 5;

            int Num2 = Num1;

            Console.WriteLine("number1 = " + Num1);// Output: 5
            Console.WriteLine("number2 = " + Num2); // Output: 5

            //// Comment : the value OF Variable Num2 will be same of the Num1 when i Run The Code

            Num1 = 10;



            Console.WriteLine("number1 = " + Num1); // Output: 10
            Console.WriteLine("number2 = " + Num2); // Output: 5

            // Comment : the output will be for Variable Num1 = 10 and Variable Num2 still equal 5 no chage becouse the refrence not change second case




            #endregion

            #region Q3 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen



            object person1 = new object();

            object person2 = new object();

            person2 = "Khaled";

            person1 = "Bassem";
         
            Console.WriteLine("Initial values:");
            Console.WriteLine("person1.Name = " + person1); // Output: Bassem
            Console.WriteLine("person2.Name = " + person2); // Output: Khaled

            person2 = person1 ;

            Console.WriteLine("\nAfter modifying person1's Name:");
            Console.WriteLine("person1.Name = " + person1); // Output: Bassem
            Console.WriteLine("person2.Name = " + person2); // Output: Bassem

            // comment :in the first case each object have uniqe refernce everyone will print inside Value
            // but in second case the is will be unreachable object for the variable (Person2)
            // Becouse he lose the refernce number for the object Name "Khaled" can't reach and print the refrence value for object(person1) 
            //who he target to him


            #endregion





            












        }
    }
}
