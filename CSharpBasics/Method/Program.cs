using System;

namespace Method
{
    class Program
    {
        static void MyMethod(string name = "Obinna")
        {
            //code to be executed
            Console.WriteLine("Hello " + name);
        }

        static void MyMethod(int age)
        {
            //code to be executed
            Console.WriteLine(age);
        }

        static void MyMethod(string name, int age)
        {
            Console.WriteLine(name + " is " + age);
        }
        
        static int MyMethod(int x,int y)
        {
            return y + x;
        }

        static void MyMethod(string player1, string player2, string player3)
        {
            Console.WriteLine("The fastest player is: " + player3);
        }

        static void My5Method(string player1 = "Joseph", string player2="Joshua", string player3="Adam")
        {
            Console.WriteLine("The fastest player is: " + player3);
        }

        static void Main(string[] args)
        {
            MyMethod("Tunde");
            MyMethod("Kaine");
            MyMethod("Amaka");
            Console.WriteLine();
            MyMethod();
            Console.WriteLine();
            MyMethod("Blessing", 5);
            MyMethod("Uche", 8);
            Console.WriteLine();
            int z = MyMethod(3, 7);
            Console.WriteLine(z);

            //Named Arguments key:value
            MyMethod(player3: "Joseph", player1: "Adam", player2: "Jombo");
            Console.WriteLine();
            My5Method("player3");

            //Method Overloading

        }
    }
}
