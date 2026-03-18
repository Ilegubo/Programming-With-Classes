using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Menu();
        string user_Choice = Console.ReadLine();
        
        if (user_Choice == "1")
        {
            Journal newJournal = new Journal();
            newJournal.
        }

    }

    static void Menu()
    {
        Console.WriteLine("1: Load");
        Console.WriteLine("2: Save");
        Console.WriteLine("3: Display");
        Console.WriteLine("4: Write Entry");
        Console.Write("Option: ");
    }


}