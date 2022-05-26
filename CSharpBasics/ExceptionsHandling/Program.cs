using System;

namespace ExceptionsHandling
{
    class Program
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - you must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted -  You are old enough");
            }
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    int[] myNum = { 1, 2, 3 };
            //    Console.WriteLine(myNum[10]);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Something went wrong...");
            //}
            //finally
            //{
            //    Console.WriteLine("The 'try catch' block has finished running");
            //}

            CheckAge(19);

        }
    }
}
