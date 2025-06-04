using System;

namespace InterfaceExample2
{ 
    class Program
    {
        public interface IShape
        {
            double CalculateArea();
        }
        public class Circle : IShape
        {
            private double radius;
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double CalculateArea()
            {
                return Math.PI * radius * radius;
            }
        }
        public class Rectangle : IShape
        {
            private double width;
            private double height;
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public double CalculateArea()
            {
                return width * height;
            }
        }
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
          
        }
        
    }
}