using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal userJournal = new Journal();
        List<string> journalPrompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    WriteNewEntry(userJournal, journalPrompts);
                    break;
                case "2":
                    userJournal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal(userJournal);
                    break;
                case "4":
                    LoadJournal(userJournal);
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select one of the following options.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, List<string> prompts)
    {
        Random randomGenerator = new Random();
        string selectedPrompt = prompts[randomGenerator.Next(prompts.Count)];
        Console.WriteLine(selectedPrompt);
        Console.Write("Your response: ");
        string userResponse = Console.ReadLine();

        Entry newJournalEntry = new Entry(selectedPrompt, userResponse);
        journal.AddEntry(newJournalEntry);
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
        Console.WriteLine("Journal has been saved.");
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
        Console.WriteLine("Journal has been loaded.");
    }
}
