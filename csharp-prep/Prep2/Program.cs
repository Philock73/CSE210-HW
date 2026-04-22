using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What grade did you get?");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("I'm sorry but you failed");
        }
    }
}