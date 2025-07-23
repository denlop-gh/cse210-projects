// Author: Dennis Lopez
// Purporse: W03 Scripture Memorizer Program

// Exceeding requirements: created a library of scriptures with references and texts, so the program can 
// randomly select a scripture to display instead of showing just one scripture.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<(Reference, string)> scriptureList = new List<(Reference, string)>
        {
            (new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),

            (new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),

            (new Reference("Mosiah", 2, 17),
            "When ye are in the service of your fellow beings ye are only in the service of your God."),

            (new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy.")
        };

        Random rnd = new Random();
        int index = rnd.Next(scriptureList.Count);
        Reference selectedReference = scriptureList[index].Item1;
        string selectedText = scriptureList[index].Item2;

        Scripture scripture = new Scripture(selectedReference, selectedText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("All words are hidden. Exiting...");
                break;
            }
            scripture.HideRandomWord();
        }
    }
}