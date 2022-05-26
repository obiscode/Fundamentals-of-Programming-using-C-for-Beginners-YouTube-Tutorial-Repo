using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2 + 3;
            Console.WriteLine(x);

            int sum1 = 40 + 60; // 100
            int sum2 = sum1 + 200; //300
            int sum3 = sum2 + sum1;//400

            string greet1 = "Hello " + "World!";
            Console.WriteLine(greet1);

            string greeting = "Hello ";
            string name = "Obinna";
            string greet2 = greeting + name;
            Console.WriteLine(greet2);

            int y = 5;

            int z = 10;
            z += 5;//output 15 same thing as z = z + 5


        }
    }
}
