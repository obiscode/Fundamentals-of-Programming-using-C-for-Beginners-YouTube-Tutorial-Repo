using System;

namespace ClassesAndObjects
{
    class Car
    {
        public string color = "red";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);


        }
    }
}
