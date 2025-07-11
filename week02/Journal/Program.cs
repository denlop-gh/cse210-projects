using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Journal Program!");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();

                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);

                Console.Write("> ");
                string response = Console.ReadLine();
                newEntry._entryText = response;

                newEntry._date = DateTime.Now.ToShortDateString();
                journal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine($"Entries loaded from {filename}.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter the name of the file to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("File saved\n");
            }
            else
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}