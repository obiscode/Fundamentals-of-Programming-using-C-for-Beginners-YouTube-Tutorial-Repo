using System;

namespace Constructors
{
    //class
    class Car
    {
        public string model; //field
        public string color;
        public int year;

        //this is a constructor for the car class
        public Car(string modelName, string color, int year)
        {
            model = modelName; // sets the initial value for model
            this.color = color;
            this.year = year;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Toyota = new Car("Corolla","grey",2013);//create an object of the caar class
            Console.WriteLine(Toyota.color + " " + Toyota.year 
               +" " + Toyota.model);//prints the value of the model
        }
    }
}
