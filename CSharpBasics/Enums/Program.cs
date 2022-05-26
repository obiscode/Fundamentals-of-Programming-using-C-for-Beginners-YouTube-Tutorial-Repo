using System;

namespace Enums
{
   
    class Program
    {
        enum Level
        {
            Low,
            Medium = 5,
            High
        }

        static void Main(string[] args)
        {
            //int myLevel = (int)Level.Low;
            //Console.WriteLine(myLevel);

            Level level = Level.High;

            switch (level)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }

        }
    }
}
