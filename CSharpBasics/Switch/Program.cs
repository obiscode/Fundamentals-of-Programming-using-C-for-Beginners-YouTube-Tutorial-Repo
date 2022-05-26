using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 6;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
            }

            int Day = 7;
            switch (Day)
            {
                case 7:
                    Console.WriteLine("Today is Saturday, it's weekend.");
                    break;
                case 1:
                    Console.WriteLine("Today is Sunday, it's weekend.");
                    break;
                default:
                    Console.WriteLine("Looking foward to the weekend");
                    break;
            }
        }
    }
}
