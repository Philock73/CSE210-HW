class Breathing : Exercise
{
    private bool _inAndOut;

    private int _ammount;

    public Breathing(bool inAndOut, string type, bool complete) : base(type, complete)
    {
        _inAndOut = inAndOut;

    }
    public void breathingProtocol()
    {
        int completion = CreateExercise();
        Animation myAnimation = new Animation();
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(completion + 1);
        int ammount;
        Console.Write("How long inbetween breaths?\n> ");
        ammount = int.Parse(Console.ReadLine());
        do{   
            do{
                if(ammount > 0 | ammount < 10)
                {
                    _ammount = ammount;
                }
                else
                {
                    Console.Write("Invalid ammount, please input inbetween 0-10\n> ");
                }
            }while(ammount < 0 | ammount > 10);

            if (_inAndOut)
            {
                Console.Clear();
                Console.WriteLine("Breath in");
                myAnimation.CountDown(_ammount);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Breath out");
                myAnimation.CountDown(_ammount);
            }
            _inAndOut = !_inAndOut;
        }while(DateTime.Now < endTime);
    }

}