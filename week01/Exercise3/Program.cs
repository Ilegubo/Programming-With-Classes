using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("This is a number guessing game.\n");
        string userResponse = "yes";
        Random magic = new Random();
        int magicNumber = magic.Next(1,101);
        int guessNumber;
        int attempts = 1;
    
            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower\n");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher\n");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Number of attempts: {attempts}");
                    Console.Write("Would like to play again? ");
                    userResponse = Console.ReadLine();
                    magicNumber = magic.Next(1,101);
                    attempts = 1;
                    Console.Clear();
                    Console.Clear();

                }
                attempts += 1;
            } while (!(guessNumber == magicNumber) && userResponse == "yes");
            Console.WriteLine("EXiting...");
    }
}