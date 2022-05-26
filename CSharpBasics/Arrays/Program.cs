using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pets = { "Dog", "Cat", "Fish", "Monkey" };
            int[] myNum = { 3, 7, 10, 4, 11 };
            Console.WriteLine(pets[1]);
            pets[2] = "Tiger";
            Console.WriteLine(pets.Length); 
            //for(int i = 0; i < pets.Length; i++)
            //{
            //    Console.WriteLine(pets[i]);
            //}
            foreach(string pet in pets)
            {
                Console.WriteLine(pet);
            }
            Array.Sort(pets);
            Console.WriteLine();
            foreach (string pet in pets)
            {
                Console.WriteLine(pet);
            }
            Console.WriteLine();
            //sort int array
            Array.Sort(myNum);
            foreach(int num in myNum)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());

            //different ways to create an array in C#
            string[] cars = new string[4];
            string[] animals = new string[3] { "Lion", "Snake", "Bird" };
            string[] books = new string[] { "Hard copy", "E book" };
            string[] users = { "Registered User", "Visiting User" };
            //declare an array
            string[] phones;
            //add values to an array
            phones = new string[] {"Iphone","Samsung","Tecno"};

        }
    }
}
