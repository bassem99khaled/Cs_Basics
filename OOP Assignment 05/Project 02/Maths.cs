﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_02
{
    internal class Maths
    {

        public static double Add(double a, double b)
        {
            return a + b;
        }


        public static double Subtract(double a, double b)
        {
            return a - b;
        }


        public static double Multiply(double a, double b)
        {
            return a * b;
        }


        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Sorry you Can't Division by zero.");

            }
            return a / b;

        }
    }
}
