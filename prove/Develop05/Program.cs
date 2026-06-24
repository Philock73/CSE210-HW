using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal myGoal = new SimpleGoal();
        myGoal.CreateGoal();
        Console.WriteLine(myGoal.GetDesplayString());
    }

}