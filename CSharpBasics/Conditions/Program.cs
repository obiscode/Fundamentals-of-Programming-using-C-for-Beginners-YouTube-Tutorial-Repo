using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            if (20 > 15)
            {
                Console.WriteLine("20 is greater than 15");
            }
            int x = 20;
            int y = 15;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int time = 20;
            if(time < 12)
            {
                Console.WriteLine("Good morning.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            int time2 = 15;
            if(time2 < 12)
            {
                Console.WriteLine("Good morining");
            }else if(time2 < 18)
            {
                Console.WriteLine("Good day");
            }
            else
            {
                Console.WriteLine("Good evening");
            }

            int time1 = 10;
            string result = (time1 < 12) ? "Good morning" : "Good day";
            Console.WriteLine(result);

        }
    }
}
