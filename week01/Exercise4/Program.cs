using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Exercise4 Project\n.");
        Console.WriteLine("This programs takes a series of numbers from the user, adds\n them to a list and then finds the sum, average, largest and smallest numbers\n.");

        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            string user_input = Console.ReadLine();
            int number = int.Parse(user_input);

            if (!(number == 0))
            {
                numbers.Add(number);
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }
            else
            {
                break;
            }
        }
        int sum = numbers.Sum();
        int length = numbers.Count;
        float average = (float)sum/length;
        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {positiveNumbers.Min()}");

        Console.WriteLine("\nThe list of positive numbers is");
        foreach (int number in positiveNumbers)
        {
            Console.WriteLine(number);
        }
    }
}