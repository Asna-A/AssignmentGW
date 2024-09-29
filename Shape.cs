using System;
public class Shape
{
   public virtual void CalculateArea()
    {
        Console.WriteLine("Calculate area");
    }

}
public class Circle:Shape
{
    public int radius {  get; set; }
    public override void  CalculateArea()
    {
        double area = 3.14 * radius * radius;
        Console.WriteLine("circle area "+area);
        
    }
}
public class Rectangle:Shape
{
    public int length {  get; set; }
    public int width { get; set; }
    public override void CalculateArea()
    {
        double area=length * width;
        Console.WriteLine("rectangle area " + area);
    }
}
public class Triangle:Shape
{
    public int height { get; set; }
    public int Base {  get; set; }

    public override void CalculateArea()
    {
        double area=0.5*Base*height;
        Console.WriteLine("triangle area " + area);
    }

    public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle();
        Console.WriteLine("enter radius");
        circle.radius = Convert.ToInt32(Console.ReadLine());
        circle.CalculateArea();

        Rectangle rectangle = new Rectangle();
        Console.WriteLine("enter length");
        rectangle.length= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter width");
        rectangle.width= Convert.ToInt32(Console.ReadLine());
        rectangle.CalculateArea();

        Triangle triangle = new Triangle();
        Console.WriteLine("enter base");
        triangle.Base= Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("enter height");
        triangle.height= Convert.ToInt32(Console.ReadLine());
        triangle.CalculateArea();



        

    }
}
}
