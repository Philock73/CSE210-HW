using System.Net;

class Menu
{
    public int ProcessMenu()
    {
        int input = 0;
        while (input < 1 || input > 5)
        {
            Console.WriteLine("Journal Program");
            Console.WriteLine("Write, Display, Save, and Load your Journal");
            Console.WriteLine("1: New Journal Entry");
            Console.WriteLine("2: Display Journal");
            Console.WriteLine("3: Read Journal from file");
            Console.WriteLine("4: Write Journal to File");
            Console.WriteLine("5: Quit");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }   
        return input; 
    }
}
