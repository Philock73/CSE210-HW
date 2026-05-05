using System;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Jobs> _job = new List<Jobs>();
        _job = Jobs.GetInfo();
        string who = Resume.GetName();
        Console.WriteLine($"Name: {who}");
        Console.WriteLine("Jobs:");
        foreach(Jobs job in _job)
        {
        Jobs.GiveInfo(job);
        }

    }
}