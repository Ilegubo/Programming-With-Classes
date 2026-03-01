using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("This is a number guessing game.\n");
        Random magic = new Random();
        int magicNumber = magic.Next(1,100);
        int guessNumber;
        int attempts = 1;
        string userResponse = "yes";
    
            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Number of attempts: {attempts}");
                    Console.Write("Would like to play again? ");
                    userResponse =Console.ReadLine();
                }
                attempts += 1;
            } while (!(guessNumber == magicNumber) && userResponse == "yes");
            Console.WriteLine("EXiting...");
    }
}