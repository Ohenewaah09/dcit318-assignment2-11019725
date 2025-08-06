using System;

namespace Abstract_Class_Method
{
    public abstract class  Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
           return Math.PI * radius *radius;
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(8);
            Console.WriteLine("Area of a circle: " + circle.GetArea());

            Shape rectangle = new Rectangle(5, 10);
            Console.WriteLine("Area of a rectangle: " + rectangle.GetArea());
        }
    }
}

