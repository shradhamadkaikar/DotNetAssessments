using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.AbstractClasses
{
    public abstract class Shape
    {
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }

    public class Circle : Shape
    {
        private int radius;
        private double area;
        private double perimeter;
        private const double PI = 3.14; 

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            area = PI * radius * radius;
        }

        public override void CalculatePerimeter()
        {
            perimeter = 2 * PI * radius;
        }

        public override string ToString()
        {
            return $"Area of Circle = {area:F2}\n" +
                   $"Perimeter of Circle= {perimeter:F2}";
        }
    }

    public class Triangle : Shape
    {
        private double side1, side2, side3;
        private double area;
        private double perimeter;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override void CalculateArea()
        {
            double s = (side1 + side2 + side3 )/ 2;
            area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override void CalculatePerimeter()
        {
            perimeter = side1 + side2 + side3;
        }

        public override string ToString()
        {
            return $"Area of Triangle = {area}\n" +
                   $"Perimeter = {perimeter}";
        }
    }

}
