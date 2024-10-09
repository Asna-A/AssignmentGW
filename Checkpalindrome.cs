using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number");
        int num = Convert.ToInt32(Console.ReadLine());
        int number = num;
        int rev = 0, rem;
        while (num > 0)
        {
            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;
        }
        if(rev==number)
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("not palindrome");
        }
    }
}
