using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("sorry", true);
        Scripture myScripture = new Scripture("1 Nephi", 3, 7, "I will go and do what the Lord has commanded");
        myScripture.GetScripture();
    }
}