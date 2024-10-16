using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ENTER FIRST NUMBER");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ENTER SECOND NUMBER");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ENTER THIRD NUMBER");
        int number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine("greater is " + number1);
        }
        else if (number2 > number1 && number2 > number1)
        {
            Console.WriteLine("greater is " + number2);
        }
        else
        {
            Console.WriteLine("greater is" + number3);
        }




        }
}
