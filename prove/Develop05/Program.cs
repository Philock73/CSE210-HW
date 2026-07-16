using System;
using System.Numerics;
using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main(string[] args)
    {
        List<BaseGoal> myGoals = new List<BaseGoal>();
        BaseGoal goals = new SimpleGoal();
        int levelPoints = 0;
        string fileName = "testing";
        int actionStep = 0;
        Menu myMenu = new Menu();
        while(actionStep != 5)
        {
            Console.Clear();
            actionStep = myMenu.DisplayMenu();
            switch(actionStep)
            {
                case 1:
                Console.Write("What is the Goal?\n 1) Simple \n 2) Eternal\n 3) Checklist\n > ");
                bool good = true;
                int type = int.Parse(Console.ReadLine());
                while(good)
                {
                    if (type > 0 & type < 5)
                        {
                            good = false;

                            if(type == 1)
                            {
                                SimpleGoal itsSimple = new SimpleGoal();
                                itsSimple.CreateGoal();
                                itsSimple.AddGoal(itsSimple, myGoals);
                            }
                            else if(type == 2)
                            {
                                EternalGoal itsEternal = new EternalGoal();
                                itsEternal.CreateGoal();
                                itsEternal.AddGoal(itsEternal, myGoals);
                            }
                            else if(type == 3)
                            {
                                ChecklistGoal itsaCheck = new ChecklistGoal();
                                itsaCheck.CreateGoal();
                                itsaCheck.AddGoal(itsaCheck, myGoals);
                            }
                        
                        }
                    else
                        {
                            Console.Write("Sorry but that doesn't match, please try again.\n > ");
                            type = int.Parse(Console.ReadLine());
                        }

                    Thread.Sleep(1000);
                }
                break;

                case 2:
                    Console.Clear();
                    Console.Write("What Goal are you wanting to record?\n");
                    int i = 1;
                    foreach(BaseGoal goal in myGoals)
                    {
                        Console.WriteLine($"{i}) " + goal.GetDesplayString());
                        i++;
                    }
                    Console.Write("> ");
                    int change = int.Parse(Console.ReadLine());
                    if(change > 0 & change <= myGoals.Count())
                    {
                        levelPoints =+ myGoals[change - 1].RecordEvent(levelPoints);
                        Console.WriteLine($"Your total points are {levelPoints}");
                        Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.WriteLine("Sorry you entered something out of the range.\nPleas try again");
                        Thread.Sleep(2000);
                    }

                break;

                 case 3:
                    Console.WriteLine("What is the file name you want to read?");
                    Console.Write("> ");
                    fileName = Console.ReadLine();
                    myGoals = goals.ReadFromFile(fileName + ".txt");
                    break;
                case 4:
                    Console.WriteLine("What is the name of the file you want to save to?");
                    Console.Write("> ");
                    fileName = Console.ReadLine();
                    foreach(BaseGoal goal in myGoals)
                    {
                        goal.WriteToFile(fileName + ".txt", myGoals);
                    }
                    break;

            }
        }
    }

}