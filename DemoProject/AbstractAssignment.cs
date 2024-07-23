using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoProject
{
    public abstract class Shapes
    {
        public abstract void CalculateArea();
    }

    public class Rectangle : Shapes
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override void CalculateArea()
        {
            double area = length * width;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }

    public class Circle : Shapes
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of Circle: {area}");
        }
    }

    internal class AbstractAssignment
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Circle circle = new Circle(1.5);

            rectangle.CalculateArea();
            circle.CalculateArea();
        }
    }
}
