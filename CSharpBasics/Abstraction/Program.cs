using System;

namespace Abstraction
{
    //Abstract class
    abstract class Animal
    {
        //abstract method
        public abstract void animalSound();

        //regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal //Derived class(inherited from Animal)
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee!");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();//create a pig object
            pig.animalSound(); // call the abstract method
            pig.sleep();//call the regular method
        }
    }
}
