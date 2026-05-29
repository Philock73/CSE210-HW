using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
       
        Menu myMenu = new Menu();
        //journalEntry.DisplayJournalEntry();
        //Console.WriteLine(journalEntry.CreateFileSystemString());
        int input = 0;
        Journal myJournal = new Journal();
        while(input != 5)
        {
            input = myMenu.ProcessMenu();
            switch(input)
            {
                case 1:
                    JournalEntry journalEntry = new JournalEntry();
                    journalEntry.CreateJournalEntry();
                    myJournal.AddJournalEntry(journalEntry);
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    myJournal.ReadFromFile("testjournal.txt");
                    break;
                case 4:
                    myJournal.WriteToFile("testjournal.txt");
                    break;

            }
        }
    }
}