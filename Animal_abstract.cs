using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_abstract
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string  Sound { get; set; }

        public abstract void MakeSound();
    }
    public class Dog:Animal
    {
        public override string Name { get; set; } = "Doggy";
        public override string Sound { get; set; } = "Bark bark";
        public override void MakeSound()
        {
            Console.WriteLine(Name+" makes sound "+Sound);
        }
        
    }
    public class Cat : Animal
    {
        public override string Name { get; set; } = "Catty";
        public override string Sound { get; set; } = "Meow Meow";
        public override void MakeSound()
        {
            Console.WriteLine(Name + " makes sound " + Sound);
        }

    }
    public class Bird : Animal
    {
        public override string Name { get; set; } = "Birdy";
        public override string Sound { get; set; } = "Chirp Chirp";
        public override void MakeSound()
        {
            Console.WriteLine(Name + " makes sound " + Sound);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog=new Dog();
            dog.MakeSound();
            Animal cat=new Cat();
            cat.MakeSound();
            Animal bird=new Bird();
            bird.MakeSound();

            

        }
    }
}
