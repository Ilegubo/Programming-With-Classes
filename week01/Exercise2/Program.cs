using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Please enter your letter percentage: ");
        string grade_percent = Console.ReadLine();
        int score = int.Parse(grade_percent);
        string letter;
        string sign = "";

        if (score >= 90)
        {
            letter = "A";
        }

        else if (score >= 80)
        {
            letter = "B";
        }

        else if (score >= 70)
        {
            letter = "C";
        }

        else if (score >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // Beginning of Stretch Challenge
        if (grade_percent.Length == 2 && !(score >= 97 || score <= 60))
        {
            if (score % 10 >= 7)
            {
                sign = "+";
            }

            else if (score % 10 < 3)
            {
                sign = "-";
            }

        }
        // End of Stretch Challenge
        Console.WriteLine($"Grade: {letter}{sign}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the test.");
        }

        else
        {
            Console.WriteLine("Your efforts are deeply appreciated however, you'll have to put in a lot more effort next time.");
        }
    }
}