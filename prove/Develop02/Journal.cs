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
}