using System;

namespace GuessingGame
{
    class Program
    {
        static int guess;
        static int target;
        static Random randNumber = new Random();
        static string input = "";
        static void Game()
        {
            //generate a random number
            target = randNumber.Next(10) + 1; //randNumber.Next(1,11)

            //prompt the user
            Console.WriteLine("Guess what number between 1 and 10 I am thinking of...");

            //read user input
            input = Console.ReadLine();

            //feedback
            if(int.TryParse(input, out guess))
            {
                if (guess == target)
                {
                    Console.WriteLine("Congratulations! You guessed " + guess +
                        " and the number I was thinking of was " + target + ".");
                }
                else
                {
                    Console.WriteLine("Too bad. You guessed " + guess + " and" +
                        " the number I was thinking of was " + target + ".");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("Press enter to continue...\n");
                Console.ReadLine();
                Game();
            }          
            
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Game();
            }
           
        }
    }
}
