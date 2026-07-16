class Menu
{
    private int _decision;
    public int DisplayMenu()
    {
        int decision;
        Console.WriteLine("Please enter what you want to do.");
        Console.WriteLine(" 1) Create a Goal \n 2) Record Goal \n 3) Load Goals \n 4) Save Goals\n 5) Quit");
        Console.Write("> ");
        decision = int.Parse(Console.ReadLine());
        if(decision > 0 & decision < 6)
        {
            _decision = decision;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Incorect input for the value, please try again.");
            Thread.Sleep(3000);
            _decision = 0;
        }
        return _decision;
    }

    
}