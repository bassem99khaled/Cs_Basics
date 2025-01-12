using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_05.Project_01
{
    internal class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }


        public Point3D() : this(0, 0, 0)
        {

        }


        public Point3D(int value) : this(value, value, value)
        {


        }


        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }


        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }


        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;
            return p1.Equals(p2);
        }


        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }


        public int CompareTo(Point3D other)
        {
            if (X != other.X)
                return X.CompareTo(other.X);
            if (Y != other.Y)
                return Y.CompareTo(other.Y);
            return Z.CompareTo(other.Z);
        }


        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        int IComparable.CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
