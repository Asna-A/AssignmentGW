using System;


namespace shape_interface
{

    public interface IShape
    {
        void CalculateArea();

        void CalculatePerimeter();

    }
    public class Circle : IShape
    {
        public int Radius { get; set; }
        public Circle(int radius) { 
            Radius = radius;
        }

        public void CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine("area of circle="+ area);
        }
        public void CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            Console.WriteLine("perimeter of circle="+perimeter);

        }
    }
    public class Rectangle : IShape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public void CalculateArea()
        {
            double area = Length * Width;
            Console.WriteLine("area of rectangle="+area);
        }
        public void CalculatePerimeter()
        {
            double perimeter = 2 * (Length + Width);
            Console.WriteLine("perimeter of Rectangle="+ perimeter);

        }
    }
    public class Triangle : IShape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public int SideC { get; set; }

        public Triangle(int sideA,int sideB,int sideC)
        {
            SideA = sideA; 
            SideB = sideB; 
            SideC = sideC;
        }
        
        public void CalculateArea()
        {
            double s=(SideA+SideB+SideC)/2;
            double area = Math.Sqrt(s*(s-SideA)*(s-SideB)*(s-SideC));
            Console.WriteLine("area of triangle="+area);
        }
        public void CalculatePerimeter()
        {
            double perimeter =SideA+SideB+SideC;
            Console.WriteLine("perimeter of triangle="+perimeter);

        }
    }

    internal class Program
        {
        static void Main(string[] args)
        {
                IShape circle = new Circle(1);
                circle.CalculateArea();
                circle.CalculatePerimeter();

                IShape rectangle = new Rectangle(1,2);
                rectangle.CalculateArea();
                rectangle.CalculatePerimeter();

                IShape triangle = new Triangle(3,4,5);
                triangle.CalculateArea();
                triangle.CalculatePerimeter();

            

        }
    }
}
