public class Entry
{
    private DateTime _date;
    private string _promptText;
    private string _entryText;

    public Entry(DateTime date, string prompt, string entry)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} - Entry: {_entryText}");
    }
    public string GetAsString()
    {
        return ($"{_date} | {_promptText} | {_entryText}");
    }

}