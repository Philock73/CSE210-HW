using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment myAssignment = new MathAssignment("Fractions", "Gerald", 7.4, 10, 18);
        EnglishAssignment paperAssignment = new EnglishAssignment("Paper", "Stephanie", "The Death of Civilisation");
        string info = myAssignment.GetMathAssignment();
        string english = paperAssignment.GetWritingInfo();
        Console.WriteLine(info);
        Console.WriteLine(english);
    }
}