using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int gift;
        Console.WriteLine("Please enter a number, when finished enter 0");
        do
        {
            Console.Write("Enter number: ");
            gift = int.Parse(Console.ReadLine());
            numbers.Add(gift);
        }while(gift != 0);
        Console.WriteLine("Here is your list:");
        Console.WriteLine(numbers.Count);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}