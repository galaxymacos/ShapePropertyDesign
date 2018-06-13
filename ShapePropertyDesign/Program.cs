using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePropertyDesign
{
    class Rectangle : IShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area => Length * Width;
        public double Parimeter => 2 * (Length + Width);

        public Rectangle(double x, double y, double length, double width)
        {
            X = x;
            Y = y;
            Length = length;
            Width = width;
        }
    }

    class Circle : IShape
    {
        private double _x;
        private double _y;
        private double _radius;
//        private double _area;

        public double X
        {
            get => _x;
            set => _x = value;
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double Area
        {
            get { return _radius*_radius*Math.PI; }
            set
            {
                _radius = Math.Sqrt(value / Math.PI);
//                _area = value;
            }
        }

        public double Parimeter
        {
            get { return 2 * Math.PI * _radius; }
            set { _radius = value / Math.PI / 2; }
        }

        public Circle(double x, double y,double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}, {nameof(_radius)}: {_radius}, {nameof(Area)}: {Area}, {nameof(Parimeter)}: {Parimeter}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircleShape = new Circle(0,0,5);
            Console.WriteLine(aCircleShape);
            aCircleShape.Area = 10;
            Console.WriteLine(aCircleShape);
        }
    }
}
