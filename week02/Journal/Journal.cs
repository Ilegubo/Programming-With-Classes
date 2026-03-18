namespace JournalApp;
using System.IO;
using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<Entry> loadEntries = new List<Entry>();
    public void Load(string fileName)
{
    if (!fileName.EndsWith(".txt") && !fileName.EndsWith(".json"))
    {
        fileName += ".json";
    }

    try
    {
        if (File.Exists(fileName))
        {
            string jsonString = File.ReadAllText(fileName);
            List<Entry>? loadedData = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            
            if (loadedData != null)
            {
                _entries = loadedData;
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error loading file: {e.Message}");
    }
}

    public void Save(string fileName)
{
    if (!fileName.EndsWith(".txt") && !fileName.EndsWith(".json"))
    {
        fileName += ".json";
    }

    try
    {
        string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
        
        File.WriteAllText(fileName, jsonString);
    }
    catch (IOException)
    {
        Console.WriteLine("Error occurred during saving!");
    }
}

    public void AddEntry(Entry newEntry)
    {
        newEntry._entryText = "";
        while (string.IsNullOrEmpty(newEntry._entryText))
        {
            Console.WriteLine(newEntry._promptText);
            Console.Write("Response: ");
            newEntry._entryText = Console.ReadLine();
        }
        _entries.Add(newEntry);
    }
    public void Display()
    {
        if (_entries.Count > 0)
        {
            foreach (Entry newEntry in _entries)
            {
                Console.Write($"{newEntry._date} {newEntry._promptText}\n");
                Console.WriteLine(newEntry._entryText);
            }
        }
        else

        {
            Console.WriteLine("\nNo entries found!\n");
        }
    }

}