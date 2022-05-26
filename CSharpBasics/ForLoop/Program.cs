using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //second example
            //for(int i = 2; i<=10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach loop
            //string[] pets = { "Dog", "Cat", "Fish", "Monkey" };
            //foreach(string pet in pets)
            //{
            //    Console.WriteLine(pet);
            //}

            //Break and Continue key words

            //for(int i = 0; i<10; i++)
            //{
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //continue keyword


            //for(int i = 0; i<10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //break in while loop

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //}

            //coninue in while lopp
            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
