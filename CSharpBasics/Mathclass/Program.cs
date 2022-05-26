using System;

namespace Mathclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math.Max(x,y)
            int theMAx = Math.Max(5, 10);
            Console.WriteLine(theMAx);

            //Math.Min(x,y)

            //Math.Sqrt(x)

            //Math.Abs(x)
            int x = -6;
            Console.WriteLine(Math.Abs(x));
            //Math.Round()
            Math.Round(9.99);
            Console.WriteLine(Math.Round(9.99));
        }
    }
}
