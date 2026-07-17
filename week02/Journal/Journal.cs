using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }   
    }

    public void WriteNewEntry()
    {
        Entry NewEntry = new Entry();
        PromptGenerator generator = new PromptGenerator();
        NewEntry._promptText = generator.GetRandomPrompt(); 
        Console.WriteLine(NewEntry._promptText);
        NewEntry._entryText = Console.ReadLine();
        NewEntry._date = DateTime.Now.ToShortDateString();
        _entries.Add(NewEntry);
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._entryText} | {entry._promptText}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string _date = parts[0];
            string _entryText = parts[1];
            string _promptText = parts[2];
            Entry NewEntry = new Entry();
            NewEntry._promptText = _promptText;
            NewEntry._entryText = _entryText;
            NewEntry._date = _date;
            _entries.Add(NewEntry);
        }
    }
}