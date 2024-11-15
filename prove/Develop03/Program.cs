using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures to choose from, I choose 3 that I liked
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("John", 1, 3), "Through him all things were made; without him nothing was made that has been made."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding.")
        };

        // This picks a random scripture from the 3.
        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[randomIndex];

        while (!selectedScripture.AreAllWordsHidden())
        {
            selectedScripture.Display();

            Console.WriteLine("\nPress enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords();
        }

        Console.WriteLine("All words are hidden.");
    }
}
