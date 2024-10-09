using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number");
        int num=Convert.ToInt32(Console.ReadLine());
        int rev=0,rem;
        while (num > 0)
        {
            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;
        }
        Console.WriteLine("reverse is " + rev);
    }
}
