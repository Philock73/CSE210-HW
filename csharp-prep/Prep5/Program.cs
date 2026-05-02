using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program.");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int PromptUserBirthYear()
    {
        Console.Write("What year were you were born? ");
        int year = int.Parse(Console.ReadLine());
        return year;
    }
    static int SquareNumber(int n1)
    {
        int square = n1 * n1;
        return square;
    }
    static void DisplayResult()
    {
        int age = 0;
        string w1 = PromptUserName();
        int number = PromptUserNumber();
        int year = PromptUserBirthYear();
        age = 2026 - year;
        int square = SquareNumber(number);
        Console.WriteLine($"{w1}, your number squared is {square}");
        Console.WriteLine($"{w1}, you will be turning {age}");
    }
    static void Main(string[] args)
    {
        DisplayMessage();
        DisplayResult();
    }
}