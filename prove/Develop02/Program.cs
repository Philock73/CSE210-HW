using System;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry journalEntry = new JournalEntry();
        journalEntry.CreateJournalEntry();
        //journalEntry.DisplayJournalEntry();
        //Console.WriteLine(journalEntry.CreateFileSystemString());

        Journal myJournal = new Journal();
        myJournal.AddJournalEntry(journalEntry);
        myJournal.DisplayJournal();
    }
}