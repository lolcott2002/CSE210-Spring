using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private string _filename = "journal.txt";

    public Journal(string filename = "journal.txt")
    {
        _filename = filename;
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

   public void SaveEntriesToFile()
    {
        try
        {
            List<string> linesToWrite = new List<string>();
            foreach (Entry entry in _entries)
            {
                linesToWrite.Add($"{entry.GetCreationDate()}||{entry.GetCreationTime()}||{entry.GetPrompt()}||{entry.GetUserEntry()}");
                linesToWrite.Add("-----");
            }
            File.WriteAllLines(_filename, linesToWrite);
            Console.WriteLine("Journal entries saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong while saving: {ex.Message}");
        }
    }

    public void LoadEntriesFromFile()
    {
        _entries.Clear();
        try
        {
            if (File.Exists(_filename))
            {
                string[] allLines = File.ReadAllLines(_filename);
                string currentEntryText = "";

                foreach (string line in allLines)
                {
                    if (line == "-----")
                    {
                        if (!string.IsNullOrEmpty(currentEntryText))
                        {
                            string[] parts = currentEntryText.Split(new string[] { "Date: ", " Time: ", "\nPrompt: ", "\nEntry: " }, StringSplitOptions.None);

                            if (parts.Length == 5)
                            {
                                string creationDate = parts[1].Trim();
                                string creationTime = parts[2].Trim();
                                string prompt = parts[3].Trim();
                                string userEntry = parts[4].Trim();

                                Entry loadedEntry = new Entry(prompt);
                                loadedEntry.SetUserEntry(userEntry);
                                _entries.Add(loadedEntry);
                            }
                        }
                        currentEntryText = "";
                    }
                    else
                    {
                        currentEntryText += line + "\n";
                    }
                }
                Console.WriteLine("Here are your old entries!");
            }
            else
            {
                Console.WriteLine("Looks like there's something wrong with the file.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"Something went wrong while loading.");
        }
    }

    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("You haven't written anything yet.");
            return;
        }

        Console.WriteLine("These are your journal entries.");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
            Console.WriteLine("-----");
        }
    }
}