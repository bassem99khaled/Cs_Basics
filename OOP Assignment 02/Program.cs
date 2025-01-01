﻿using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography;
using OOP_Assignment_02.Company;

namespace OOP_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region 1.	Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.


            //Person[] persons = new Person[3];
            //persons[0] = new Person("Bassem", 25);
            //persons[1] = new Person("Ahmed", 30);
            //persons[2] = new Person("Khaled", 35);


            //Console.WriteLine("Details of Persons:");


            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            #endregion

            #region 2.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.


            //    Console.WriteLine("Enter the coordinates of the first point (X Y):");
            //    Point p1 = ReadPoint();

            //    Console.WriteLine("Enter the coordinates of the second point (X Y):");
            //    Point p2 = ReadPoint();

            //    double distance = CalculateDistance(p1, p2);
            //    Console.WriteLine($"The distance between the points is: {distance}");


            //static Point ReadPoint()
            //{
            //    string[] input = Console.ReadLine().Split();
            //    return new Point(double.Parse(input[0]), double.Parse(input[1]));
            //}

            //static double CalculateDistance(Point p1, Point p2)
            //{
            //    return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            //}


            #endregion


            #region 3.	Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.


            //Person01[] persons = new Person01[3];


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    persons[i] = new Person01 { Name = name, Age = age };
            //}


            //Person01 oldest = persons[0];
            //foreach (var person in persons)
            //{
            //    if (person.Age > oldest.Age)
            //    {
            //        oldest = person;
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");


            #endregion
            #endregion

            #region Part 02

            #region 1.	Design and implement a Class for the employees in a company:
            //        Notes:
            //●	Employee is identified by an ID, Name, security level, salary, hire date and Gender.
            //●	We need to restrict the Gender field to be only M or F[Male or Female]
            //●	Assign the following security privileges to the employee(guest, Developer, secretary and DBA) in a form of Enum.
            //●	We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [Use String.Format() Function].



            //     try
            //    {

            //        Employee employee = new Employee(
            //            id: 1,
            //            name: "Bassem khaled",
            //            gender: 'M',
            //            security: SecurityLevel.Developer,
            //            salary: 75000,
            //            hireDate: new DateTime(2020, 5, 1)
            //        );


            //Console.WriteLine(employee);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }


            #endregion

            #region 2- Develop a Class to represent the Hiring Date Data:	Consisting of fields to hold the day, month and Years.

            //try
            //{
             
            //    HiringDate hireDate = new HiringDate(1, 1, 2025);
            //    Console.WriteLine($"Hiring Date: {hireDate}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            #endregion



            #endregion

        }
    }
}
