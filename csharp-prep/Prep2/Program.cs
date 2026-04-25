using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What grade did you get?");
        string grade = Console.ReadLine();
        string letter;
        string sign;
        int percent = int.Parse(grade);
        int secondletter = percent % 10;
        
        if (secondletter >= 7)
        {
            sign = "+";
        }
        else if (secondletter <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (percent >= 70)
        {
            if (percent >= 90)
            {
                if (sign == "+")
                {
                    sign = "";
                }
                letter = "A";
                Console.WriteLine($"You got an {letter}{sign}!");
            }
            else if (percent >= 80)
            {
                letter = "B";
                Console.WriteLine($"You got a {letter}{sign}");
            }
            else
            {
                letter = "C";
                Console.WriteLine($"You got a {letter}{sign}");
            }
            Console.WriteLine("You passed!");
        }
        else
        {
            if (percent >= 60)
            {
                letter = "D";
                Console.WriteLine($"you got a {letter}{sign}");
            }
            else
            {
                letter = "F";
                Console.WriteLine($"You got a {letter}");
            }
            Console.WriteLine("I'm sorry but you failed");
        }
    }
}