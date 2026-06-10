class Animation
{
    
    
    public void MakeAnimation()
    {
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(1);
        
        string animationString = "-\\|/";
        int index = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(150);
            Console.Write("\b");
        }
    }
    public void CountDown()
    {
        Console.WriteLine("How long?");
        int seconds = int.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(seconds);
        while(DateTime.Now < endTime)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b\b");
            seconds--;
        }
    }
}
