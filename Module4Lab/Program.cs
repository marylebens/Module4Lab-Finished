using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("The computer is thinking of a number between 1-100. Can you guess it?");

        // Generate a random number between 1 and 100
        Random random = new Random();
        int targetNumber = random.Next(1, 101);

        int userGuess;
        do
        {
            // Prompt user for a guess
            Console.Write("Enter your guess: ");
            while (!int.TryParse(Console.ReadLine(), out userGuess))
            {
                Console.Write("Invalid input. Please enter a number: ");
            }

            // Compare the guess to the target number
            if (userGuess > targetNumber)
            {
                Console.WriteLine("Your guess is too high. Try again.");
            }
            else if (userGuess < targetNumber)
            {
                Console.WriteLine("Your guess is too low. Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number!");
            }

        } while (userGuess != targetNumber);

        // Congratulate the user
        Console.WriteLine("You won! Thanks for playing the Guessing Game!");
    }
}