using System;

class Program
{
    static void Main(string[] args)
    {
        int actionStep = 0;
        Menu myMenu = new Menu();
        while(actionStep != 4)
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
                    if (type > 0 & type < 4)
                        {
                            good = false;

                            if(type == 1)
                            {
                                SimpleGoal itsSimple = new SimpleGoal();
                                itsSimple.CreateGoal();
                                Console.WriteLine(itsSimple.GetDesplayString());
                            }
                            else if(type == 2)
                            {
                                EternalGoal itsEternal = new EternalGoal();
                                itsEternal.CreateGoal();
                            }
                            else if(type == 3)
                            {
                                ChecklistGoal itsaCheck = new ChecklistGoal();
                                itsaCheck.CreateGoal();
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

            }
        }
    }

}