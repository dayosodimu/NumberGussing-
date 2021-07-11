using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a secret number from 1-100, for a player to guess 
            //Player to guess too low
            //Player to guess too high 
            //Player  to guess secert number
            //Player limited number of guesses

            Random numberGenerator = new Random();
            int secertNumber = numberGenerator.Next(1, 100);

            Console.WriteLine("Guess a secert random number inbetween 1 and 100");


            bool gameWon = false;

            for (int i = 0; i < 5; i++)
            {
                string userInput = Console.ReadLine();

                int userGuess = int.Parse(userInput);

                if (userGuess > secertNumber)

                {
                    Console.WriteLine("Too high! Guess lower...");
                }

                if (userGuess < secertNumber)
                {
                    Console.WriteLine("Too lower! Guess Higher...");
                }

                if (userGuess == secertNumber)
                {
                    gameWon = true;
                    Console.WriteLine("You Win!");
                    break;
                }

            }

            if (gameWon == false)
            {
                Console.WriteLine("you loss");
            }

            Console.WriteLine("Loop is done");

        }
    }
}
