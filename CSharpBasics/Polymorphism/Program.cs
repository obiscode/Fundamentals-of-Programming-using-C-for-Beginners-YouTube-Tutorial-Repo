using System;

namespace Polymorphism
{
    class Animal//Base class
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Pig : Animal //Derived class
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee!");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal(); // creates a myAnimal object
            Animal pig = new Pig(); //creates a pig object
            Animal dog = new Dog(); //creates a dog object

            myAnimal.animalSound();
            pig.animalSound();
            dog.animalSound();
        }
    }
}
