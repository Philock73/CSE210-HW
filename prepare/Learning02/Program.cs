using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Jobs job = new Jobs();
        Jobs.GetInfo(job);
        Jobs.GiveInfo(job);
    }
}