using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number");
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        while (num>0)
        {
            int lastnum = num % 10;
            sum += lastnum;
            num /= 10;
        }
        Console.WriteLine("sum is "+sum);
    }
}
