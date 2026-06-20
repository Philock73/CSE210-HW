using System;

class Program
{

    static void Main(string[] args)
    {
        Scripture randomScripture = new Scripture();
        Scripture MemorizeScripture = randomScripture.GetRandom();
        MemorizeScripture.GetScripture();
    }
}