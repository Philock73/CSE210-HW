using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment myAssignment = new MathAssignment("Fractions", "Gerald", 7.4, 10, 18);
        string info = myAssignment.GetMathAssignment();
        Console.WriteLine(info);
    }
}