using System;
public class Calculator
{
    public double add(double number1,double number2)
    { 
        return number1 + number2; 
    }
    public double subtract(double number1,double number2) { 
        return number1 - number2;
    }
    public double multiply(double number1,double number2) 
    {
        return number1 * number2; 
    }
    public double divide(double number1,double number2)
    {
        return number1 / number2;
    }
}
public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("enter first number");
        double number1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number");
        double number2= Convert.ToInt32(Console.ReadLine());

        Calculator calculator = new Calculator();
        double add=calculator.add(number1,number2);
        double sub=calculator.subtract(number1,number2);
        double multiply=calculator.multiply(number1,number2);
        double divide=calculator.divide(number1,number2);

        Console.WriteLine("addition result " + add);
        Console.WriteLine("substraction result " + sub);
        Console.WriteLine("multiplication result "+multiply);
        Console.WriteLine("division result "+divide);
        
    }
}
