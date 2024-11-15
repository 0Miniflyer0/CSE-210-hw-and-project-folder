using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry log in _entries)  
        {
            Console.WriteLine(log); 
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry log in _entries)  
            {
                writer.WriteLine($"{log.GetDate()}|{log.GetPrompt()}|{log.GetResponse()}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines) 
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry log = new Entry(parts[1], parts[2]);  
                    log.SetDate(DateTime.Parse(parts[0]));
                    _entries.Add(log);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
