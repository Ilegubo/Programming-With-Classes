using System;
// Used a spinning stroke animation in the terminal.
namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice = "";

            while (menuChoice != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Option: ");

                menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    BreathingActivity activity = new BreathingActivity();
                    activity.Run();
                }
                else if (menuChoice == "2")
                {
                    ReflectingActivity activity = new ReflectingActivity();
                    activity.Run();
                }
                else if (menuChoice == "3")
                {
                    ListingActivity activity = new ListingActivity();
                    activity.Run();
                }
            }
        }
    }
}