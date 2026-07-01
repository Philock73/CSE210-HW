using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations.Schema;

class Program
{
    static void Main(string[] args)
    {
        bool breathingcompletion = false;
        bool listingcompletion = false;
        bool reflectioncompletion = false;
        Menu myMenu = new Menu();
        Breathing myBreathing = new Breathing(true, "Breathing", false);
        Listing myListing = new Listing(5,"Listing", false);
        Reflection myReflection = new Reflection(0, "Reflection", false);
        Animation myAnimation = new Animation();
        int input = 0;
        while(input != 4)
        {
            Console.Clear();
            input = myMenu.DisplayMenu();
            switch (input)
            {
                case 1:
                    // Breathing
                    if(!breathingcompletion)
                    {
                        myBreathing.breathingProtocol(); 

                        breathingcompletion = myBreathing.CheckCompletion();
                    }
                    else
                    {
                        Console.WriteLine("You have already completed this excersise this session.");

                        myAnimation.MakeAnimation(3);
                    }
                    break;
                case 2:
                    // Listing
                    if(!listingcompletion)
                    {
                        myListing.listingProtocal(); 

                        listingcompletion = myListing.CheckCompletion();
                    }
                    else
                    {
                        Console.WriteLine("You have already completed this excersise this session.");

                        myAnimation.MakeAnimation(3);
                    }
                    break;
                case 3:
                    // Reflection
                    if(!reflectioncompletion)
                    {
                        myReflection.reflectionProtocal(); 

                        reflectioncompletion = myReflection.CheckCompletion();
                    }
                    else
                    {
                        Console.WriteLine("You have already completed this excersise this session.");

                        myAnimation.MakeAnimation(3);
                    }
                    break;
                
            }
        }
        
    }
}