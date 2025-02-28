using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurchargeOperateur
{
    internal class Point
    {
        private int _x = 0;
        private int _y = 0;
        //Constructeurs
        public Point() { }
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        //Accesseurs et mutateurs
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        //To String
        public override string ToString()
        {
            return $"La coordonnée en x est {_x} et la coordonnée en y est {_y}";
        }
        //Surcharge en +
        public static Point operator +(Point a, Point b)
        {
            Point point = new Point();
            point.X = a.X + b.X;
            point.Y = a.Y + b.Y;
            return point;
        }

        public static Point operator -(Point a, Point b)
        {
            Point point = new Point();
            point.X = a.X - b.X;
            point.Y= a.Y - b.Y;
            return point;
        }
    }
}
