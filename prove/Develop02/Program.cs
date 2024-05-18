using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    Console.Write("Enter filename to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveJournalToFile(saveFileName);
                    break;
                case 4:
                    Console.Write("Enter filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadJournalFromFile(loadFileName);
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void WriteNewEntry()
    {
        Console.WriteLine("Writing a new entry...");

        Random rand = new Random();
        int promptIndex = rand.Next(prompts.Count);
        string prompt = prompts[promptIndex];

        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        
        Console.Write("Mood: ");
        string mood = Console.ReadLine();
        
        Console.Write("Weather: ");
        string weather = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response, mood, weather);
        entries.Add(newEntry);

        Console.WriteLine("Entry added successfully!");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}, Mood: {entry.Mood}, Weather: {entry.Weather}");
        }
    }

    public void SaveJournalToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response},{entry.Mood},{entry.Weather}");
            }
        }
        Console.WriteLine("Journal saved to file successfully!");
    }

    public void LoadJournalFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        string mood = parts[3];
                        string weather = parts[4];
                        Entry entry = new Entry(date, prompt, response, mood, weather);
                        entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded from file successfully!");
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }
}
class Entry
{
    public string Date { get; private set; }
    public string Prompt { get; private set; }
    public string Response { get; private set; }
    public string Mood { get; private set; }
    public string Weather { get; private set; }

    public Entry(string prompt, string response, string mood, string weather)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
        Mood = mood;
        Weather = weather;
    }

    public Entry(string date, string prompt, string response, string mood, string weather)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
        Weather = weather;
    }
}


// What did I do to exceed the requirements? Save other information in the journal entry. Entry class: Added "mood" and "weather" properties.
// Updated constructors to include the new properties.
// Updated WriteNewEntry method to prompt the user for mood and weather.
// Updated "DisplayJournalToFile and LoadJournalFromFile.