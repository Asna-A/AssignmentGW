using System;
public class Animal
{

    public string Name { get; set; }
    
    public virtual void Sound()
    {
        Console.WriteLine("I can make Sound");
    }
}
public class Dog:Animal
{
    public override void Sound()
    {
        Console.WriteLine("I make dog sound");
    }
}
public class Cat:Animal
{
    public override void Sound()
    {
        Console.WriteLine("i make cat sound");
    }
}
public class Bird:Animal
{
    public override void Sound()
    {
        Console.WriteLine("i make bird sound");
    }
}
public class Program
{
    public static void Main(string[] args)
    {

        Animal d=new Dog();
        d.Name = "Dog";
        Console.WriteLine("Iam a " + d.Name);
        d.Sound();
        
        
        Animal c = new Cat();
        c.Name = "Cat";
        Console.WriteLine("Iam a " + c.Name);
        c.Sound();

        Animal B = new Bird();
        B.Name = "Bird";
        Console.WriteLine("Iam a " + B.Name);
        B.Sound();
       

    }
}
