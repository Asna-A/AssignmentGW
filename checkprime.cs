using System;

public class Program
{
    public static void Main(string[] args)
    {
        int flag = 0;
        Console.WriteLine("enter number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == 2) 
        {
            flag = 0;
        }
        else if(num==1)
        {
            flag=1;
        }
        else
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("prime");
        }
        else
        {
            Console.WriteLine("not prime");
        }

    }
}
