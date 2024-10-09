using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter amount");
        int amount = Convert.ToInt32(Console.ReadLine());
        double tax;
        int switch_tax;
        if (amount < 10000)
        {
            switch_tax=1;
        }
        else if (amount > 10000 && amount < 15000)
        {
            switch_tax=2; 
        }
        else if (amount > 15000 && amount < 20000)
        {
            switch_tax=3; 
        }
        else if (amount > 20000 && amount < 25000)
        {
            switch_tax=4;
        }
        else
        {
            switch_tax=5;
        }
        switch(switch_tax)
        {
            case 1:tax=(5.0 / 100) * amount;
                break;
            case 2:tax = (7.5 / 100) * amount;
                break;
            case 3:tax = (10.0 / 100) * amount;
                break;
            case 4:tax = (12.5 / 100) * amount;
                break;
            case 5:
            default:tax = (15.0 / 100) * amount;
                break;
        }
        Console.WriteLine("tax is " + tax);
    }
}
