class Journal
{
    List<JournalEntry> _journalentries = new List<JournalEntry>();

    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalentries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalentries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }
    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(JournalEntry entry in _journalentries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }
}