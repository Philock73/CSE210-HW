class Animation
{
    
    public void MakeAnimation()
    {
        string animationString = "+/-|/";
        for (int i = 0; i < 20; i++)
        {
            Console.Write(animationString[i % animationString.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }
}
