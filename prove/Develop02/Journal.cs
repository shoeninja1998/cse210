public class Journal{
    public List<Entry> _entries = new();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
           Console.WriteLine(entry.GetEntry());
        }
    }
    public void SaveToFile(string filename)
    {
        using StreamWriter outputFile = new(filename);
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine(entry.GetEntry());
            Console.WriteLine("Entry successfully saved.");
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('-');
            Entry entryObject = new()
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(entryObject);
        }
    }
}