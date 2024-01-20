public class Entry{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void WriteEntry()
    {
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
        _date = $"Date: {DateTime.Now}";
    }
    public string GetEntry()
    {
        return $"{_date} - {_promptText} - {_entryText}";
    }

}