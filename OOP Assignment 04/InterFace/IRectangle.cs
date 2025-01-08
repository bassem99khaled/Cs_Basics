using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_04.InterFace 
{
    internal interface IRectangle : IShape
    {
        class Rectangle : IRectangle
        {

            public double Length { get; set; }
               public double Width { get; set; }

        public double Area => Length * Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area:F2}");
        }
    }
}
}
