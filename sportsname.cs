using System;
using System.Reflection.Emit;

public class Program
{
    public static void Main(string[] args)
    {
    Label:
        Char chara = Console.ReadLine()[0];
        switch (chara)
        {
            case 'c':
                Console.WriteLine("Cricket");
                break;
            case 'f':
                Console.WriteLine("Football");
                break;
            case 'h':
                Console.WriteLine("Hockey");
                break;
            case 't':
                Console.WriteLine("Tennis");
                break;
            case 'b':
                Console.WriteLine("Badminton");
                break;
            default:
                {
                    Console.WriteLine("Invalid input, please try again");
                    goto Label;
                }

        }
    }
}
