using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Random number = new Random();
        int magic = number.Next(1,100);
        Console.WriteLine("What is the magic number?");
        string guess = Console.ReadLine();
        int guessednumber = int.Parse(guess);
        Console.WriteLine($"{magic}");
    }
}