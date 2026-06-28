using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        int input = 0;
        while(input != 4)
        {
            Console.Clear();
            input = myMenu.DisplayMenu();
            switch (input)
            {
                case 1:
                    // Breathing
                    Breathing myBreathing = new Breathing(true, "Breathing", false);
                    myBreathing.breathingProtocol(); 
                    break;
                case 2:
                    // Listing
                    break;
                case 3:
                    // Reflection
                    break;
                
            }
        }
        
    }
}