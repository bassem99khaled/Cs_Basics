using System.ComponentModel;
using System.Drawing;
using System.Linq;
namespace Assignment04
{
    internal class Assignment04
       
    {
        static void Main(string[] args)
        {

            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.



            //Console.Write("Enter an integer: ");

            //int userNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out userNumber);

            //if (isValid && userNumber > 0)
            //{
            //    Console.WriteLine("Numbers from 1 to " + userNumber + ":");

            //    for (int i = 1; i <= userNumber; i++)
            //    {
            //        if (i == userNumber)
            //        {
            //            Console.Write(i); // Avoid trailing comma
            //        }
            //        else
            //        {
            //            Console.Write(i + ", ");
            //        }
            //    }

            //}

            #endregion


            #region 2- Write a program that allows the user to insert an integer then  print a multiplication table up to 12.


            //Console.Write("Please enter an integer: ");


            //int userNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out userNumber);


            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(userNumber * i);

            //        if (i < 12)
            //        {
            //            Console.Write(" "); 
            //        }
            //    }

            //    Console.WriteLine(); 




            #endregion


            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number


            //Console.Write("Please enter an integer: ");

            //int userNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out userNumber);



            //    Console.WriteLine("Even numbers from 1 to " + userNumber + ":");

            //    for (int i = 2; i <= userNumber; i += 2)
            //    {
            //        Console.Write(i);

            //        if (i + 2 <= userNumber)
            //        {
            //            Console.Write(" "); 
            //        }
            //    }


            #endregion


            #region  4 - Write a program that takes two integers then prints the power.


            //Console.Write("Enter the base number: ");
            //int baseNumber;
            //bool isBaseValid = int.TryParse(Console.ReadLine(), out baseNumber);

            //Console.Write("Enter the exponent: ");
            //int ExponentNumber;
            //bool Exponent = int.TryParse(Console.ReadLine(), out ExponentNumber);


            //    long result = 1;
            //    for (int i = 0; i < ExponentNumber; i++)
            //    {
            //        result *= baseNumber;
            //    }


            //    Console.WriteLine($"{baseNumber}^{ExponentNumber} = {result}");



            #endregion


            #region 5- Write a program to allow the user to enter a string and print the REVERSE of it.



            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();


            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedString = new string(charArray);


            //Console.WriteLine("Reversed string: " + reversedString);



            #endregion


            #region 6- Write a program in C# Sharp to find prime numbers within a range of numbers.



            //Console.Write("Input starting number : ");
            //        int.TryParse(Console.ReadLine(), out int start);


            //        Console.Write("Input ending number: ");
            //         int.TryParse(Console.ReadLine(), out int end);


            //        Console.Write($"The prime numbers between {start} and {end} are: ");


            //        for (int num = start; num <= end; num++)
            //        {
            //            if (IsPrime(num))
            //            {
            //                Console.Write($"{num} ");
            //            }
            //        }


            //    }

            //    static bool IsPrime(int number)
            //    {

            //        if (number <= 1) return false;
            //        if (number == 2) return true;
            //        if (number % 2 == 0) return false;


            //        int sqrt = (int)Math.Sqrt(number);
            //        for (int i = 3; i <= sqrt; i += 2)
            //        {
            //            if (number % i == 0)
            //            {
            //                return false;
            //            }
            //        }
            //        return true;


            #endregion


            #region 7- . Write a program in C# Sharp to convert a decimal number into binary without using an array.



            //Console.Write("Enter a decimal number: ");
            //int decimalNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out decimalNumber);


            //Console.Write("Binary representation: ");

            //string binary = string.Empty;
            //while (decimalNumber > 0)
            //{
            //    binary = (decimalNumber % 2) + binary;
            //    decimalNumber /= 2;
            //}

            //Console.WriteLine($"The Binary of number you enter is {binary}");




            #endregion


            #region   8 - .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of




            //Console.Write("Enter the size of matrix: ");
            //int n;
            //bool isValid = int.TryParse(Console.ReadLine(), out n);


            //    Console.WriteLine("Identity Matrix:");


            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //            {
            //                Console.Write("1 ");
            //            }
            //            else
            //            {
            //                Console.Write("0 ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }




            #endregion


            #region 9- Write C# program that Extract a substring from a given string.


            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();


            //Console.Write("Enter the starting index: ");
            //int startIndex;
            //bool StartIndex = int.TryParse(Console.ReadLine(), out startIndex);

            //Console.Write("Enter the length of the substring: ");
            //int length;
            //bool Flag = int.TryParse(Console.ReadLine(), out length);

            //if (StartIndex && Flag && startIndex >= 0 && length >= 0 && startIndex + length <= input.Length)
            //{

            //    string substring = input.Substring(startIndex, length);
            //    Console.WriteLine($"Extracted substring:  {substring}");
            //}


            #endregion


            #region 10- Write C# program that take two string variables and print them as one variable 


            //    Console.Write("Enter the first string: ");
            //    string firstString = Console.ReadLine();


            //    Console.Write("Enter the second string: ");
            //    string secondString = Console.ReadLine();


            //string result = firstString + ' '+ secondString;
            //    Console.WriteLine($"Combined string: {result}");


            #endregion


            #region 11 - .Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.Write("Enter the size of  matrix : ");


            //int.TryParse(Console.ReadLine(), out int n);

            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {

            //            if (i == j)
            //            {
            //                Console.Write("1 ");
            //            }
            //            else
            //            {
            //                Console.Write("0 ");
            //            }
            //        }

            //        Console.WriteLine();
            //    }



            #endregion


            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.



            //    Console.Write("Enter the size of the array: ");
            //        int.TryParse(Console.ReadLine(), out int size);



            //    int[] numbers = new int[size];


            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter element {i + 1}: ");
            //        if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //        {
            //            Console.WriteLine($"Invalid input for element {i + 1}. Please enter a valid integer.");
            //            return;
            //        }
            //    }


            //    int sum = 0;
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        sum += numbers[i];
            //    }
            //Console.Write(" [ ");
            //for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.Write(numbers[i]);
            //        if (i < numbers.Length - 1)
            //            Console.Write(", ");
            //    }
            //Console.Write("] ");
            //Console.WriteLine($"The sum of all elements is: ({sum})");


            #endregion


            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.



            //Console.Write("Enter the size of the arrays: ");
            //int size;
            //bool isValidSize = int.TryParse(Console.ReadLine(), out size);

            //if (isValidSize && size > 0)
            //{
            //    int[] array1 = new int[size];
            //    int[] array2 = new int[size];
            //    int[] mergedArray = new int[2 * size];


            //    Console.WriteLine("Enter the elements of the first array :");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        while (!int.TryParse(Console.ReadLine(), out array1[i]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter an integer:");
            //        }
            //    }


            //    Console.WriteLine("Enter the elements of the second array :");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        while (!int.TryParse(Console.ReadLine(), out array2[i]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter an integer:");
            //        }
            //    }


            //    int index1 = 0, index2 = 0, mergeIndex = 0;
            //    while (index1 < size && index2 < size)
            //    {
            //        if (array1[index1] < array2[index2])
            //        {
            //            mergedArray[mergeIndex++] = array1[index1++];
            //        }
            //        else
            //        {
            //            mergedArray[mergeIndex++] = array2[index2++];
            //        }
            //    }


            //    while (index1 < size)
            //    {
            //        mergedArray[mergeIndex++] = array1[index1++];
            //    }


            //    while (index2 < size)
            //    {
            //        mergedArray[mergeIndex++] = array2[index2++];
            //    }


            //    Console.WriteLine("Merged array in ascending order:");
            //    for (int i = 0; i < mergedArray.Length; i++)
            //    {
            //        Console.Write(mergedArray[i] + " ");
            //    }
            //}



            #endregion


            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.


            //Console.Write("Enter the size of the array: ");
            //if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer.");
            //    return;
            //}


            //int[] numbers = new int[size];
            //Console.WriteLine("\nEnter the elements:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //        return;
            //    }
            //}


            //Console.WriteLine("\n The array elements are:");
            //Console.WriteLine($"[ {string.Join(" , ", numbers)} ]");


            //Console.WriteLine("\nFrequency of each element:");
            //numbers.GroupBy(x => x)
            //      .Select(group => new { Element = group.Key, Frequency = group.Count() })
            //      .ToList()
            //      .ForEach(item => Console.WriteLine($"Element {item.Element} appears {item.Frequency} time(s)"));


            #endregion


            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array



            //Console.Write("Enter the size of the array: ");
            //int size;
            //bool isValidSize = int.TryParse(Console.ReadLine(), out size);

            //if (isValidSize && size > 0)
            //{
            //    int[] array = new int[size];

            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        int element;
            //        while (!int.TryParse(Console.ReadLine(), out element))
            //        {
            //            Console.WriteLine("Invalid input. Please enter an integer:");
            //        }
            //        array[i] = element;
            //    }

            //    int max = int.MinValue;
            //    int min = int.MaxValue;

            //    foreach (int num in array)
            //    {
            //        if (num > max)
            //        {
            //            max = num;
            //        }

            //        if (num < min)
            //        {
            //            min = num;
            //        }
            //    }

            //    Console.WriteLine("The maximum element in the array is: " + max);
            //    Console.WriteLine("The minimum element in the array is: " + min);
            //}



            #endregion


            #region 16- Write a program in C# Sharp to find the second largest element in an array.




            //Console.Write("Enter the size of the array: ");
            //int size;
            //bool isValidSize = int.TryParse(Console.ReadLine(), out size);

            //if (isValidSize && size > 1)
            //{
            //    int[] array = new int[size];


            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        int element;
            //        while (!int.TryParse(Console.ReadLine(), out element))
            //        {
            //            Console.WriteLine("Invalid input. Please enter an integer:");
            //        }
            //        array[i] = element;
            //    }


            //    int largest = int.MinValue;
            //    int secondLargest = int.MinValue;

            //    foreach (int num in array)
            //    {
            //        if (num > largest)
            //        {
            //            secondLargest = largest;
            //            largest = num;
            //        }
            //        else if (num > secondLargest && num != largest)
            //        {
            //            secondLargest = num;
            //        }
            //    }

            //    if (secondLargest == int.MinValue)
            //    {
            //        Console.WriteLine("There is no second largest element in the array.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The second largest element in the array is: " + secondLargest);
            //    }
            //}




            #endregion


            #region 17-. Consider an Array of Integer values with size N, having values as    
            // in this Example

            //7      0    0   0   0   5   6   7   5   0   7   5   3

            //write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).

            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.

            //Note:
            //-Array values will be taken from the user
            //-If you have input like 1111111 then the distance is the number of
            //Cells between the first and the last cell.


            // ---------------------------------------------------------------


            //Console.WriteLine("Enter the size of the array :");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            //{
            //    Console.WriteLine("Please enter  array size:");
            //}

            //int[] arr = new int[size];


            //Console.WriteLine("\nEnter the array elements:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        Console.Write("Please enter a valid integer: ");
            //    }
            //}





            #endregion


            #region 18- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.





            //Console.WriteLine("Enter the  array:");
            //Console.Write("Number of rows: ");
            //int rows;
            //while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
            //{
            //    Console.Write("enter a  number for rows: ");
            //}

            //Console.Write("Number of columns: ");
            //int cols;
            //while (!int.TryParse(Console.ReadLine(), out cols) || cols <= 0)
            //{
            //    Console.Write("enter a number for columns: ");
            //}


            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];


            //Console.WriteLine("\nEnter elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element at position [{i},{j}]: ");
            //        while (!int.TryParse(Console.ReadLine(), out firstArray[i, j]))
            //        {
            //            Console.Write($"enter number [{i},{j}]: ");
            //        }
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("\nFirst Array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(firstArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\nSecond Array (Copied from First Array):");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region 19- Write a Program to Print One Dimensional Array in Reverse Order



            //Console.WriteLine("Enter the size of the array:");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            //{
            //    Console.Write("enter array size: ");
            //}

            //int[] array = new int[size];


            //Console.WriteLine("\nEnter the array elements:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out array[i]))
            //    {
            //        Console.Write($"enter element {i + 1}: ");
            //    }
            //}


            //Console.WriteLine("\nOriginal Array:");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();



            //Console.WriteLine("\nArray in Reverse Order:");
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();

            #endregion




            #region Methods Of Array ( Task )

            #region Arrary.IndexOf

            //var Fruits = new[] { "Melon", "Coconut", "Lemon" ,"Tomato", "Apple", "Banana" };

            //var Result = Array.IndexOf(Fruits, "Lemon"); // Get the Number of Object in the Array

            //Console.WriteLine(Result);
            //Console.ReadKey();
            #endregion

            #region Array.Exisit

            //var Fruits = new[] { "Melon", "Coconut", "Lemon" ,"Tomato", "Apple", "Banana" };

            //var Result = Array.Exists(Fruits, fruit => fruit.Contains("C"));  // Chicks to see whether or not item exists in an array
            //Console.WriteLine(Result);
            //Console.ReadKey();

            #endregion

            #region Array.Find

            //var Fruits = new[] { "Melon", "Coconut", "Lemon" ,"Tomato", "Apple", "Banana" };

            //var Result = Array.Find(Fruits, fruit => fruit.Contains("C"));  // Find item in the array (finding the first item get this condition)
            //Console.WriteLine(Result);
            //Console.ReadKey();


            #endregion

            #region Array.FindLast

            //var Fruits = new[] { "Melon", "Coconut", "Lemon" ,"Tomato", "Apple", "Banana"};

            //var Result = Array.FindLast(Fruits, fruit => fruit.Contains("l"));  // Find the last Object exist this Condintion
            //Console.WriteLine(Result);
            //Console.ReadKey();

            #endregion

            #region Array.FindIndex

            //var Fruits = new[] { "Melon", "Coconut", "Lemon","Tomato", "Apple", "Banana" };

            //var Result = Array.FindIndex(Fruits, fruit => fruit.Contains("e"));  // Grt the first object (Index) in array exist the condtion is have ("C")
            //Console.WriteLine(Result);
            //Console.ReadKey();

            #endregion

            #region Array.FindAll

            //var Fruits = new[] { "Melon", "Coconut", "Lemon" ,"Tomato", "Apple", "Banana"};

            //var Result = Array.FindAll(Fruits, fruit => fruit.Contains("n"));  // Get All Items  in the Array contaion the thing i searching for


            //foreach (var Fruit in Result)
            //{
            //    Console.WriteLine(Fruit);
            //}

            //Console.ReadKey();

            #endregion

            #region  Array.Reverse

            //var Fruits = new[] { "Melon", "Coconut", "Lemon" ,"Tomato", "Apple", "Banana" };

            //Array.Reverse(Fruits);  // Reverse all object in the Array


            //foreach (var Fruit in Fruits)
            //{
            //    Console.WriteLine(Fruit);
            //}

            //Console.ReadKey();


            #endregion

            #region Array.Copy

            //var Fruits = new[] { "Melon", "Coconut", "Lemon", "Tomato", "Apple", "Banana" };
            //var FruitsCopy = new string[Fruits.Length];

            //Array.Copy(Fruits, FruitsCopy, 5); // Copy items to new array in which size i want


            //foreach (var Fruit in FruitsCopy)
            //{
            //    Console.WriteLine(Fruit);
            //}

            //Console.ReadKey();

            #endregion

            #region Array.Sort

            //var Fruits = new[] { "Melon", "Coconut", "Lemon", "Tomato", "Apple", "Banana" };
            //var FruitsCopy = new string[Fruits.Length];

            //Array.Sort(Fruits); // Sort the items in array with Aplhabetical order


            //foreach (var Fruit in Fruits)
            //{
            //    Console.WriteLine(Fruit);
            //}

            //Console.ReadKey();


            #endregion

            #region Array.Sort (Reverse)

            //    var Fruits = new[] { "Melon", "Coconut", "Lemon", "Tomato", "Apple", "Banana" };
            //    var FruitsCopy = new string[Fruits.Length];

            //    Array.Sort(Fruits, new ReverseComparer()); // Sort the items in array with (Reverse) Aplhabetical order


            //    foreach (var Fruit in Fruits)
            //    {
            //        Console.WriteLine(Fruit);
            //    }

            //    Console.ReadKey();
            //}

            //public class ReverseComparer : IComparer<String>
            //{
            //    public int Compare(string x, string y)
            //    {
            //        return y.CompareTo(x);
            //    }


            #endregion

            #region Array.BinarySearch

            //var fruits = new[] { "Melon", "Coconut", "lemon", "Tomato", "Apple", "Banana" , "Lemon" , "Apple"};

            //Array.Sort(fruits);

            //foreach (var Fruit in fruits)
            //{
            //    Console.WriteLine(Fruit);
            //}


            //var index = Array.BinarySearch(fruits, "Orange");
            //if (index < 0)
            //{
            //    Console.WriteLine($"\n Sorry The object you searching for isn't in the array");
            //}
            //else
            //{
            //    Console.WriteLine($"\n Fruit you searching for is Index Number : {index}");
            //}

            #endregion


            #endregion


            using System.Security.Authentication;

namespace DEMO_05
    {

        // Class
        // interface
        // enum
        // struct
        internal class Demo05
        {

            //Function
            // Data

            // types of function
            // 1. class member function [static function]
            // 2. object member function [non static function]


            // print (*-*)

            public static void PrintShape(int count = 10, string pattern = "*-*")
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(pattern);
                }
            }

            public static void Swap(ref int X, ref int Y)
            {
                int temp = X;
                X = Y;
                Y = temp;
            }


            public static int SumArray(int x, params int[] arr)
            {

                // sum +1 =1
                // 1+2 = 3
                // 3+3=6
                int sum = 0;
                //arr = new int[] { 4, 5, 6};
                //arr[0] = 100 ;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                return sum;
            }


            public static void SumMul(int x, int y, ref int Sum, ref int Mul)
            {
                Sum = x + y;
                Mul = x * y;
                //return sum;
                //return mul;

            }
            static void Main(string[] args)
            {
                #region Casting [ Boxing - Unboxing ]

                // refernce type Casting => Convert from Reference to to refernce type
                // Boxing Casting => Convert from value type to reference type
                // unboxing casting => convert from erefernce type to value type

                //object obj = new object();
                //obj = "Mostafa"; // refernce type casting
                //obj = 2; //boxing casting from value type [int] to reference type [ object]

                #region Boxing [ Safe Code ]

                //int x = 10;
                //object obj01 = new object();
                //obj01 = x;

                //Console.WriteLine(obj01);
                //parent = child
                // Dog is animal
                #endregion

                #region Unboxing [ Unsafe Code ]

                //object obj02 = new object();
                //obj02 = 10;
                //int x = (int)obj02;
                //Console.WriteLine(x);
                //child = parent
                // anilmal is Dogs
                #endregion

                #endregion

                #region Nullable Data Type
                #region Value type

                ////int x = null // int numbrt only

                //int? x = null; //int number and null

                //Console.WriteLine(x);

                //int x = 10;
                //int? y = x; //Accepted


                //int? x = 10;
                //int y = (int)x; //not accepted because cant convert null to int 

                //int? x = null;
                //int y;
                //if (x != null)
                //{
                //    y = (int)x; //casting
                //}
                //else {
                //    y = 0;
                //     }

                //Console.WriteLine(y);

                //if (x.hasvalue)
                //{
                //    yield = x.value;  // not casting using in work **** 

                //}
                //else
                //{
                //    y = 0;
                //}

                //y = x.HasValue ? X.Value : 0;


                #endregion

                #region Reference Type

                //string? Name = null;

                //Console.WriteLine(Name);




                #endregion

                #endregion

                #region Null Propagation Operator

                //int[] Number = null;

                //for (int i = 0; Number!=null && i < Number.Length; i++) // not using in real
                //    {
                //        Console.WriteLine(Number[i]);
                //    }


                //for (int i = 0;  i < Number?.Length; i++) //  not using in real 
                //    {
                //        Console.WriteLine(Number[i]);
                //    }


                //if (Number != null) // using in real because one check only in first not looping
                //{

                //    for (int i = 0; i < Number.Length; i++) 
                //    {
                //        Console.WriteLine(Number[i]);
                //    }
                //}



                // i < Numbers?.Length
                // Numbers => Object [ Length ]
                // Numbers => Null [ Null ]


                //int lenghth = Number?.Length ?? 0;  

                //Console.WriteLine(lenghth);


                //employee emp = new employee();

                //emp.Department = new Department();

                ////if (emp != null)
                //{
                //    if (emp.Department != null)
                //    {
                //        Console.WriteLine(emp.Department.Name);
                //    }
                //}
                //Console.WriteLine(emp?.Department.Name?? "Not Found");
                #endregion

                #region Funcations

                //PrintShape(10 , "*-*");
                //PrintShape ( pattern: "*-*" , count: 10)
                //PrintShape();

                // Hello Mostafa 
                // Welcome to Route

                //Console.WriteLine("Hello Mostafa\n Welcome To\tRoute");
                //PrintShape(@"/*\\", 10); // add @ or make duble \\ to scape meaning



                #endregion

                #region Value Type Paramters

                #region By Value

                //int A = 5;
                //int B = 9;
                //Console.WriteLine(B);
                //Console.WriteLine(A);

                //Swap(A, B);

                //Console.WriteLine(B);
                //Console.WriteLine(A);

                #endregion
                #region By Reference

                //int A = 5;
                //int B = 9;
                //Console.WriteLine(B);
                //Console.WriteLine(A);

                //Swap(ref A, ref B);

                //Console.WriteLine(B);
                //Console.WriteLine(A);

                #endregion

                #endregion


                #region Reference Type
                #region Ex01
                #region By Value
                //int[] Number = { 1, 2, 3 };
                //Console.WriteLine(SumArray(Number));
                //Console.WriteLine(Number[0]);


                #endregion

                #region By reference

                //int[] Number = { 1, 2, 3 };
                //Console.WriteLine(SumArray(ref Number));
                //Console.WriteLine(Number[0]);

                #endregion
                #endregion

                #region Ex02
                #region  By Value

                //int[] Number = { 1, 2, 3 };
                //Console.WriteLine(SumArray(Number));
                //Console.WriteLine(Number[0]);

                #endregion
                #region By ref
                //int[] Number = { 1, 2, 3 };
                //Console.WriteLine(SumArray(ref Number));
                //Console.WriteLine(Number[0]);

                #endregion
                #endregion

                #endregion

                #region Functions - passing by out

                //int A = 10;
                //int B = 20;
                //int Sum, Mul;
                //SumMul(A, B, ref Sum, ref Mul);

                //Console.WriteLine(Sum);
                //Console.WriteLine(Mul);

                #endregion

                #region Functions - Params
                //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //Console.WriteLine(SumArray({ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});


                //int A = 10 , B = 20 , C = 30;
                //Console.WriteLine("A : {0} , B: {1} , C: {2}", A , B , C);


                #endregion
            }
        }
    }

}
}
}