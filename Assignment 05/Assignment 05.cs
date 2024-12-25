using System.ComponentModel;

namespace Assignment_05
{
    internal class Program
    {

      
            static void Main(string[] args)
        {

            #region  1 - Explain the difference between passing(Value type parameters) by value and by reference then write a suitable c# example.


            // in Value Type :
            // i can change from Object to any Data type than mean (Safe Code) Because i am sure that not making Error while Running Code
            // if there is Data Type Have Null option it will Make error while running [all Datay type genrated From Object]

            // Reference Type: 
            //  it is (not Safe Code) Beacause i can make opposite get Data Type == Object but Data type not allow null
            // when i get this problem the program will stop if i forget making Option the Data type allow null Same invite (?) after Data type
            // or add (!) Before Equal or making If condtion to check Null.




            //int x = 10;
            //int? y = x; //Accepted //example for Value type
            //Console.WriteLine(x);


            //int? x = null;
            //int y;
            //if (x != null)  // using if Condtion to protect Code from debuging
            //{
            //    y = (int)x; 
            //}
            //else {
            //    y = 0;
            //     }


            //string? Name = null;

            //Console.WriteLine(Name); // example for refernce type

            #endregion

            #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //        public static void Swap(ref string Name01, ref string Name02)
            //{
            //    String Change = "Mohamed";
            //    Name01 = Name02;
            //    Name02 = Change;
            //}

            // Passing by value: means that a copy of the reference is passed to the method Any changes to the object itself are reflected
            // but reassigning the reference inside the method does not affect the original reference

            // Passing by reference: means that Changes to the object or reassigning the reference affect the original variable.

            //Passing By Value:

            //string Name01 = "Bassem";
            //String Name02 = "Khaled";

            //Console.WriteLine(Name01);
            //Console.WriteLine(Name02);

            //Swap( Name01, Name02);

            //Console.WriteLine(Name01);
            //Console.WriteLine(Name02);

            // using Ref Type:

            //string Name01 = "Bassem";
            //String Name02 = "Khaled";

            //Console.WriteLine(Name01);
            //Console.WriteLine(Name02);

            //Swap( ref Name01, ref Name02);

            //Console.WriteLine(Name01);
            //Console.WriteLine(Name02);




            #endregion

            #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers



            //static (int sum, int difference) Calculate(int num1, int num2, int num3, int num4)
            //    {
            //        int sum = num1 + num2;
            //        int difference = num3 - num4;
            //        return (sum, difference);
            //    }


            //        Console.Write("Enter the first number: ");
            //        int num1 = int.Parse(Console.ReadLine());

            //        Console.Write("Enter the second number: ");
            //        int num2 = int.Parse(Console.ReadLine());

            //        Console.Write("Enter the third number: ");
            //        int num3 = int.Parse(Console.ReadLine());

            //        Console.Write("Enter the fourth number: ");
            //        int num4 = int.Parse(Console.ReadLine());


            //        var result = Calculate(num1, num2, num3, num4);

            //        Console.WriteLine($"The sum of the first two numbers is: {result.sum}");
            //        Console.WriteLine($"The difference of the last two numbers is: {result.difference}");


            #endregion

            #region  4 - Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Output should be like
            //Enter a number: 25
            //The sum of the digits of the number 25 is: 7


            //static int SumOfDigits(int number)
            //{
            //    int sum = 0;
            //    while (number != 0)
            //    {
            //        sum += number % 10; 
            //        number /= 10;
            //    }
            //    return sum;
            //}


            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());


            //    int result = SumOfDigits(number);


            //    Console.WriteLine($"The sum of the digits of the number {number} is: {result}");




            #endregion

            #region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //static bool IsPrime(int Number)
            //{
            //    if (Number <= 1)
            //    {
            //        return false;
            //    }
            //    for (int i = 2; i < Number; i++)
            //    {
            //        if (Number % i == 0)
            //            return false;
            //    }
            //    return true;
            //}

            //Console.WriteLine("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Is the number {number} prime: {IsPrime(number)}");
            #endregion

            #region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //static void MinMaxArray(int[] array, out int min, out int max)
            //{
            //    min = array[0];
            //    max = array[0];

            //    foreach (int value in array)
            //    {
            //        if (value < min)
            //            min = value;

            //        if (value > max)
            //            max = value;
            //    }
            //}

            //Console.Write("Enter the size of the array: ");
            //    int size = int.Parse(Console.ReadLine());
            //    int[] array = new int[size];

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }


            //MinMaxArray(array, out int min, out int max);
            //Console.WriteLine($"Minimum value is: {min}");
            //Console.WriteLine($"Maximum value is: {max}");

            #endregion

            #region 7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter



            //static long Factorial(int number)
            //{
            //    long result = 1;
            //    for (int i = 1; i <= number; i++)
            //    {
            //        result *= i;
            //    }
            //    return result;
            //}




            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //   Console.WriteLine($"The factorial of {number} is: {(number)}");





            #endregion

            #region  8 - Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter





            //static string ChangeChar(string input, int position, char newChar)
            //{
            //    char[] chars = input.ToCharArray();
            //    chars[position] = newChar;
            //    return new string(chars);
            //}

           
            //    Console.Write("Enter a string: ");
            //    string input = Console.ReadLine();

            //    Console.Write("Enter the position of litter will change: ");
            //    int position = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the new character: ");
            //    char newChar = Console.ReadLine()[0];

            //    string result = ChangeChar(input, position, newChar);
            //    Console.WriteLine($"Modified string: {result}");
      

        #endregion







    }
}
}
