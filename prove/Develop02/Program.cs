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
        string fileName = "testing";
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
                    Console.WriteLine("What is the file name you want to read?");
                    Console.Write("> ");
                    fileName = Console.ReadLine();
                    myJournal.ReadFromFile(fileName + ".txt");
                    break;
                case 4:
                    Console.WriteLine("What is the name of the file you want to save to?");
                    Console.Write("> ");
                    fileName = Console.ReadLine();
                    myJournal.WriteToFile(fileName + ".txt");
                    break;

            }
        }
    }
}