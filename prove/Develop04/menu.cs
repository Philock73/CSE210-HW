class Menu
{
    private int _response;
    public int DisplayMenu()
    {
        Console.WriteLine("What exercise are you wanting to accomplish today? \n 1: Breathing\n 2: Listing\n 3: Reflecting\n 4: Quit");
        Console.Write("> ");
        int response = int.Parse(Console.ReadLine());
        if(response > 4 | response < 1)
        {
            Animation waiting = new Animation();
            Console.WriteLine("Sorry you have entered an invalid option please try again.");
            waiting.MakeAnimation(3);
            _response = 0;
        }
        else
        {
            _response = response;
        }
        return _response;
    }
}