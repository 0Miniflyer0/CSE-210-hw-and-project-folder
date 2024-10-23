using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    public string Book { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int startVerse)
    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = null;
    }

    public Reference(string book, int startVerse, int endVerse)
    {
        Book = book;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse != null)
            return $"{Book} {StartVerse}-{EndVerse}";
        else
            return $"{Book} {StartVerse}";
    }
}

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string Display()
    {
        return IsHidden ? "____" : Text;
    }
}

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index].Hide();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.ToString());

        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List of scriptures to choose from, I choose 3 that i liked
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

        Console.WriteLine("All words are hidden. Goodbye!");
    }
}
