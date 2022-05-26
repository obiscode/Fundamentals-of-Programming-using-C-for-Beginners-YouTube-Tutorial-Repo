using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // type variableName = value;
            string name = "Obinna";
            int x = 40;
            double y = 33.34;
            char ch = 'c';
            bool isTrue = true;

            string lastName;//declare the variable 
            lastName = "Ezeh";//assigned a value to the variable

            name = "Sunday";

            string firstName = name;

            string fullName = firstName + " " + lastName;
            //display varaible to the console

            Console.WriteLine("My name is " + fullName);

            const double PI = 3.14159;
            // PI = 3.4; you cannot change a const value

            double result = x + y;//+ when used with numbers is addition mathematical expression
            double subResult = x - y;//- is subtraction
            double mulResult = x * y;// * is multiplication
            double divResult = x / y;// / is division
            Console.WriteLine("addition result: " + result);
            Console.WriteLine("subtraction result: " + subResult);
            Console.WriteLine("multiplication result: " +mulResult);
            Console.WriteLine("division result: " + divResult);

            int a, b, c;
            a = b = c = 10;
            Console.WriteLine(a + b + c);
        }
    }
}
