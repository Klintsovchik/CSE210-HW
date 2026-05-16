public class Journal
{
    private List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();
        foreach(Entry entry in _entries)
        {
            lines.Add(entry.GetAsString());
        }
        File.WriteAllLines(file, lines);


    }
   public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();
        string[] lines = File.ReadAllLines(file);
        foreach(string line in lines)
        {
            string[] parts = line.Split('|');
            DateTime date = DateTime.Parse(parts[0]);
            Entry entry = new Entry(date, parts[1], parts[2]);
            _entries.Add(entry);
        }
    }
}