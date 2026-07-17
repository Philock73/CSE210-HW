using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures myLecture = new Lectures("Dylan B. Cruel", 150, "Lecture", "Getting Through the Hard", "While it can be hard, how can we use them to turn around?", "August 5th, 2026", 17, "365 Western Hallow");
        Reception myReception = new Reception("martin@crabmail.com", "Reception", "Martin's Wedding", "Martin is marrying Gissele", "December 11th, 2027", 18, "123 Fallstreal Coral, CA");
        OutDoorGatherings myOutDoorGatherings = new OutDoorGatherings("Sprinkling", "Outdoor Gatherings", "Water Volleyball", "Playing Volleyball with the Ward", "July 25th, 2026", 20, "5432 Sarahnova Clear Atome, WA");
        string lectureTime = myLecture.SetAdditionalInfo();
        string receptionTime = myReception.SetAdditionalInfo();
        string outDoorGatheringsTime = myOutDoorGatherings.SetAdditionalInfo();
        myLecture.ShortDiscription();
        Console.WriteLine("");
        myReception.ShortDiscription();
        Console.WriteLine("");
        myOutDoorGatherings.ShortDiscription();
        Console.WriteLine("");
        myLecture.FullDetails(lectureTime);
        Console.WriteLine("");
        myReception.FullDetails(receptionTime);
        Console.WriteLine("");
        myOutDoorGatherings.FullDetails(outDoorGatheringsTime);
        Console.WriteLine("");
        myLecture.StandardDetails();
        Console.WriteLine("");
        myReception.StandardDetails();
        Console.WriteLine("");
        myOutDoorGatherings.StandardDetails();
        Console.WriteLine("");
    }
}