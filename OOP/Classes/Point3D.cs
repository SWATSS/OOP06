using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes
{
    internal class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            X = Y = Z = default;
        }
        public Point3D(int x)
        {
            X = Y = Z = x;
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return (left.X == right.X && left.Y == right.Y && left.Z == right.Z);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return (left.X != right.X || left.Y != right.Y || left.Z != right.Z);
        }


        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            if (obj is Point3D other)
            {
                int Xcompare = X.CompareTo(other.X);
                if (Xcompare != 0) return Xcompare;
                return Y.CompareTo(other.Y);
            }
            throw new ArgumentException("Object is not a Point3D :( ");
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
