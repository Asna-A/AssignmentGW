using System;
public class Program
{
    public static void Main(string[] args)
    {
        int a = 0, b = 1,c=0,i=0;
        Console.WriteLine("enter COUNT");
        int count=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("fibonacci series...");
        Console.WriteLine(a);
        Console.WriteLine(b);
        while(i<count-2)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
            i++;
            

        }


    }
}
