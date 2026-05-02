using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
class Program
{
    static (int, int, double) MathEquations(List<int> l1)
    {
        int big = 0;
        int all = 0;
        double avg = 0;    
            foreach (int n1 in l1)
        {
            all = all + n1;
            avg = all / l1.Count;
            if (n1 > big)
            {
                big = n1;
            }
            Console.WriteLine($"{n1}");
        }
        return (big, all, avg);


    }
    static void Main(string[] args)
    {
        int greatest = 0;
        int total = 0;
        double average = 0;
        int gift;
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter a number, when finished enter 0");
        do
        {
            Console.Write("Enter number: ");
            gift = int.Parse(Console.ReadLine());
            numbers.Add(gift);
        }while(gift != 0);
        numbers.Remove(0);
        Console.WriteLine("Here is your list:");
       
        (greatest, total, average) = MathEquations(numbers);
       
        
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The biggest number you listed is: {greatest}");
    }
}