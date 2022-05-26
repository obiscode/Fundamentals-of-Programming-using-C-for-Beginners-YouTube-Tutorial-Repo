using System;

namespace ClassMembers
{   //the class 
    class Car
    {
        //class members
       public string color; //field
       public int maxSpeed; //field
       public int year;//field
        public string model; //field

        public void Drive() //method
        {
            Console.WriteLine("Your car is driving...") ;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Car myObj = new Car();
            //myObj.color = "blue";
            //myObj.maxSpeed = 200;
            //Console.WriteLine(myObj.color);
            //Console.WriteLine(myObj.maxSpeed);

            Car Toyota = new Car();
            Toyota.model = "Corolla";
            Toyota.color = "Silver";
            Toyota.year = 2014;
            Toyota.maxSpeed = 300;

            Car Lexus = new Car();
            Lexus.model = "ES 330";
            Lexus.color = "Black";
            Lexus.maxSpeed = 250;
            Lexus.year = 2010;

            Console.WriteLine(Toyota.model);
            Console.WriteLine(Lexus.model);

            Lexus.Drive(); //calls the Drive method of the Car class
        }
    }
}
