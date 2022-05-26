using System;

namespace Interfaces
{
    //interface
    interface IAnimal
    {
        void animalSound();//interface method does not have a body
        void run();//interface method
    }

    //interface
    interface IFarmYard
    {
        void Feeding();
    }

    //Pig class implements the IAnimal interface
    class Pig : IAnimal, IFarmYard
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee!");
        }

        public void Feeding()
        {
            Console.WriteLine("The pig is eating...");
        }

        public void run()
        {
            Console.WriteLine("Pig is running...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();//Create a pig object
            pig.animalSound();
            pig.Feeding();
        }
    }
}
