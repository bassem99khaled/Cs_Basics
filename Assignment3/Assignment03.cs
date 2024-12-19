using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Assignment03
    {
        static void Main(string[] args)
        {

            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.



            //Console.Write("Input: ");

            // int number=int.TryParse(Console.ReadLine(), 


            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("Output: Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Output: No");
            //    }


            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.



            //Console.Write("Input Number: ");


            // int number=int.TryParse(Console.ReadLine(),


            //     if (number < 0)
            //         {
            //        Console.WriteLine("Output: negative");
            //         }
            //    else if (number > 0)
            //         {
            //            Console.WriteLine("Output: positive");
            //         }



            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.WriteLine("Please enter three integers:");


            //string[] inputs = Console.ReadLine().Split(' ');

            //if (inputs.Length == 3 &&
            //    int.TryParse(inputs[0], out int num1) &&
            //    int.TryParse(inputs[1], out int num2) &&
            //    int.TryParse(inputs[2], out int num3))
            //{

            //    int maxElement = Math.Max(num1, Math.Max(num2, num3));
            //    int minElement = Math.Min(num1, Math.Min(num2, num3));


            //    Console.WriteLine("Max element = " + maxElement);
            //    Console.WriteLine("Min element = " + minElement);
            //}


            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.



            //Console.Write("Please enter an integer: ");


            //int userNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out userNumber);

            //if (isValid)
            //{

            //    if (userNumber % 2 == 0)
            //    {
            //        Console.WriteLine("The number is even.");
            //    }
            //    else if (userNumber % 2 != 0)
            //    {
            //        Console.WriteLine("The number is odd.");
            //    }
            //}
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).


            //Console.Write("Input: ");


            //    string input = Console.ReadLine();

            //    if (input.Length > 0)
            //    {

            //        char ch = char.ToLower(input[0]);


            //        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //        {
            //            Console.WriteLine("Output: vowel");
            //        }
            //        else if (char.IsLetter(ch))
            //        {
            //            Console.WriteLine("Output: Consonant");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Please enter a valid letter.");
            //        }
            //    }


            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.



            //Console.Write("Input: ");


            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    Console.Write("Outputs: ");


            //    for (int i = 1; i <= 12; i++)
            //    {

            //        int result = number * i;


            //        if (i < 12)
            //        {
            //            Console.Write($"{result} ");
            //        }
            //        else
            //        {
            //            Console.Write(result);
            //        }
            //    }

            //    Console.WriteLine();




            #endregion

            #region 9 - Write a program that takes two integers then prints the power.


            //Console.Write("Input: ");


            //string[] inputs = Console.ReadLine().Split(' ');

            //if (inputs.Length == 2 &&
            //    int.TryParse(inputs[0], out int Num01) &&
            //    int.TryParse(inputs[1], out int Num02))
            //     {

            //double result = Math.Pow(Num01, Num02);

            //if (result <= int.MaxValue && result >= int.MinValue)
            //{
            //    Console.WriteLine($"Output: {(int)result}");
            //}
            //else
            //{
            //    Console.WriteLine($"Output: {result}");
            //}
            //     }


            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.





            //Console.WriteLine("Enter marks of five subjects :");

            //string[] inputs = Console.ReadLine().Split(' ');

            //if (inputs.Length == 5 &&
            //    int.TryParse(inputs[0], out int mark1) &&
            //    int.TryParse(inputs[1], out int mark2) &&
            //    int.TryParse(inputs[2], out int mark3) &&
            //    int.TryParse(inputs[3], out int mark4) &&
            //    int.TryParse(inputs[4], out int mark5))
            //{

            //    int totalMarks = mark1 + mark2 + mark3 + mark4 + mark5;
            //    double averageMarks = totalMarks / 5.0;
            //    double percentage = (totalMarks / 500.0) * 100;

            //    Console.WriteLine("Total marks = " + totalMarks);
            //    Console.WriteLine("Average marks = " + averageMarks);
            //    Console.WriteLine("Percentage = " + percentage + "%");
            //}


            #endregion


            #region 11- Write a program to input the month number and print the number of days in that month.


            //Console.Write("Enter month number : ");


            //int monthNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out monthNumber);


            //    int daysInMonth = 0;

            //    switch (monthNumber)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            daysInMonth = 31;
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            daysInMonth = 30;
            //            break;
            //        case 2:
            //            daysInMonth = 28; 
            //            break;
            //    }

            //    Console.WriteLine("Days in Month: " + daysInMonth);


            #endregion

            #region 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.




            // Console.WriteLine("Enter x1 y1:");
            // string[] point1 = Console.ReadLine().Split();
            // double x1 = double.Parse(point1[0]);
            // double y1 = double.Parse(point1[1]);


            // Console.WriteLine("Enter x2 y2:");
            // string[] point2 = Console.ReadLine().Split();
            // double x2 = double.Parse(point2[0]);
            // double y2 = double.Parse(point2[1]);


            // Console.WriteLine("Enter x3 y3:");
            // string[] point3 = Console.ReadLine().Split();
            // double x3 = double.Parse(point3[0]);
            // double y3 = double.Parse(point3[1]);

            //// if the area = zero the 3 point is straight line
            // double area = 0.5 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));


            // if (Math.Abs(area) < 0.1)
            // {
            //     Console.WriteLine("The points lie on a straight line.");
            // }
            // else
            // {
            //     Console.WriteLine("The points do not lie on a straight line.");
            // }




            #endregion


            #region 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            //            -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //            - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //            - If the worker takes more than 5 hours, they are required to leave the company.
            //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.



            //Console.Write("Enter the time in hours to complete the task: ");


            //double timeSpent = int.Parse(Console.ReadLine());



            //    if (timeSpent >= 2 && timeSpent <= 3)
            //    {
            //        Console.WriteLine("Worker is highly efficient.");
            //    }
            //    else if (timeSpent > 3 && timeSpent <= 4)
            //    {
            //        Console.WriteLine("Worker needs to increase their speed.");
            //    }
            //    else if (timeSpent > 4 && timeSpent <= 5)
            //    {
            //        Console.WriteLine("Worker needs training to improve speed.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Worker must leave the company.");
            //    }

            #endregion


            #region 21-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            //    int Num01 = 10;
            //    Console.WriteLine($"Initial value of firstNumber: {Num01}"); //10

            //    int Num02 = Num01; 
            //    Console.WriteLine($"Initial value of secondNumber: {Num02}"); //10

            //    Num02 = 20;

            //    Console.WriteLine($"Value of firstNumber: {Num01}");  // 10
            //    Console.WriteLine($"Value of secondNumber: {Num02}"); // 20

            //// Num02 will get the new value input 


            #endregion

            #region 22 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen




            //object person1 = new object();

            //object person2 = new object();

            //person2 = "Khaled";

            //person1 = "Bassem";

            //Console.WriteLine("Initial values:");
            //Console.WriteLine("person1.Name = " + person1); // Output: Bassem
            //Console.WriteLine("person2.Name = " + person2); // Output: Khaled

            //person2 = person1;

            //Console.WriteLine("\nAfter modifying person1's Name:");
            //Console.WriteLine("person1.Name = " + person1); // Output: Bassem
            //Console.WriteLine("person2.Name = " + person2); // Output: Bassem

            //object person2 get the same hashcode then get the same string write in person1 and the string in person2 will be unreachable object



            #endregion




            #region 23-	Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            //Console.WriteLine(d);

            //b)	A value 1 will be assigned to d.


            #endregion

            #region 24-	Which of the following is the correct output for the C# code given below?

            // Console.WriteLine(13 / 2 + " " + 13 % 2);


            //d)	6 1



            #endregion



            #region 25-	What will be the output of the C# code given below?

            //int num = 1, z = 5;
            //               if (!(num <= 0))
            //                   Console.WriteLine(++num + z++ + " " + ++z);
            //             else
            //                  Console.WriteLine(--num + z-- + " " + --z);

            //d)	7 7


            #endregion



        }
    }
}

