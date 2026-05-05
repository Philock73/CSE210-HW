using System.Net;
using System.Runtime.InteropServices;
public class Resume
{
    public string name = " ";
    public static string GetName()
    {
        Console.Write("What is your name: ");
        string who = Console.ReadLine();
        return who;
    }
}
