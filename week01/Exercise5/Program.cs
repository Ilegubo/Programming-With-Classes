using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string userName = PromptUserName();
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favNumber = int.Parse(number);
        int favSquare = SquareNumber(favNumber);
        DisplayResult(userName, favSquare);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }

    static int SquareNumber(int number)
    {
        return number*number;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of you number is {number}");
    }

}