using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Random number = new Random();
        int magic = number.Next(1,100);
        int confused = 0;
        int x = 1;
        while (confused == 0)
        {
             Console.WriteLine("What is the magic number?");
            string guess = Console.ReadLine();
            int guessednumber = int.Parse(guess);
            if (guessednumber == magic)
            {
                confused = 1;
            }
            else if (guessednumber > magic)
            {
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("Guess Higher");
            }
            x++;
        }
       
        
        Console.WriteLine($"That's it! The magic number is:{magic}");
        Console.WriteLine($"It took you {x} guesses");
    }
}