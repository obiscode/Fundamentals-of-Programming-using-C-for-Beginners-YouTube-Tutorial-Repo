using System;

namespace AccessModifiers
{
    class Car
    {
        public string model = "Volvo";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}
