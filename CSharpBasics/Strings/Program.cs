 using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";

            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("the length of the text string is: " + text.Length);

            //ToUpper() and ToLower()

            string greet = "Good Morning";
            Console.WriteLine(greet.ToUpper());
            Console.WriteLine(text.ToLower());

            string firstName = "Obinna ";
            string lastName = "Ezeh";
            string name = firstName + lastName;
            Console.WriteLine(name);

            //string.Concat()
            string name2 = string.Concat(firstName, lastName);
            Console.WriteLine(name2);

            string name3 = $"My full name is: {firstName}{lastName}";
            Console.WriteLine(name3);

            string myString = "Hope";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString[1]);

            Console.WriteLine(myString.IndexOf("p"));

            //Substring()

            string fullName = "Obinna Ezeh";

            int charPos = fullName.IndexOf("E");

            string lastName1 = fullName.Substring(charPos);

            Console.WriteLine(lastName1);

            string txt = "You are the real \"MVP\" for getting this far";

            // \' this will insert a single quote in a string
            // \" inserts a double quote in a string
            // \\ this will insert a single backslash in a string

            int x = 5;
            int y = 3;
            Console.WriteLine(x+y);// 8

            string x1 = "5";
            string x2 = "3";
            Console.WriteLine(x1 + x2);//53

         















        }
    }
}
