using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_04.InterFace
{
    internal interface ICircle : IShape
    {
        class Circle : ICircle
        {
            public double Radius { get; set; }

            public double Area => Math.PI * Radius * Radius;

            public Circle(double radius)
            {
                Radius = radius;
            }

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
            }
        }
    }
}
