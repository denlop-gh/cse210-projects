using System.IO;
public class Journal

{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        {
            _entries.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string _date = parts[0];
                string _promptText = parts[1];
                string _entryText = parts[2];

                Entry entry = new Entry();
                entry._date = _date;
                entry._promptText = _promptText;
                entry._entryText = _entryText;
                _entries.Add(entry);
            }
        }
    }

}