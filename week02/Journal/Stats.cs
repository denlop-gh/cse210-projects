using System;
using System.IO;

public class Stats
{
    public int totalEntries = 0;
    private string statsFile = "stats.txt";

    public void LoadStats()
    {
        if (File.Exists(statsFile))
        {
            string content = File.ReadAllText(statsFile);
            int.TryParse(content, out totalEntries);
        }
        else
        {
            totalEntries = 0;
        }
    }

    public void IncrementEntries()
    {
        totalEntries++;
    }

    public void SaveStats()
    {
        File.WriteAllText(statsFile, totalEntries.ToString());
    }
}