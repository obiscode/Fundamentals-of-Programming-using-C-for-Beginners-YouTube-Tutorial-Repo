using System;

namespace Inheritance
{
    sealed class Vehicle //Parent class or Base class
    {
        public string brand = "Lexus"; //vehicle field
        public void Start()//Vehicle method
        {
            Console.WriteLine("Engine starting...");
        }
    }

    class Car : Vehicle// the child class or derived class
    {
        public string modelName = "RX 350";
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create myCar object
            Car myCar = new Car();

            //call the start() method from the Vehicle class on myCar object
            myCar.Start();

            Console.WriteLine(myCar.brand);
        }
    }
}
