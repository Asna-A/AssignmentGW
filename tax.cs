using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter amount");
        int amount = Convert.ToInt32(Console.ReadLine());
        double tax;
        if (amount < 10000)
        {
            tax=(5.0 / 100) * amount;
            Console.WriteLine("tax is " + tax);
        }
        else if (amount > 10000 && amount < 15000)
        {
            tax = (7.5 / 100) * amount;
            Console.WriteLine("tax is " + tax);
        }
        else if (amount > 15000 && amount < 20000)
        {
            tax = (10.0 / 100) * amount;
            Console.WriteLine("tax is " + tax);
        }
        else if (amount > 20000 && amount < 25000)
        {
            tax = (12.5 / 100) * amount;
            Console.WriteLine("tax is " + tax);
        }
        else
        {
            tax = (15.0 / 100) * amount;
            Console.WriteLine("tax is " + tax);
        }
    }
}
