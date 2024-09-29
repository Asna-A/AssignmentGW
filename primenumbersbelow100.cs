using System;
public class Program
{
    public static void Main(string[] args)
    {
        int flag = 0;
        int num;
        num = 1;
        while (num < 100) 
        {
            
            if (num == 2)
            {
                flag = 0;
            }
            else if (num == 1)
            {
                flag = 1;
            }
            else
            {
                flag = 0;
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

                Console.WriteLine(num);
            }
            num++;
        }
        

    }
}
