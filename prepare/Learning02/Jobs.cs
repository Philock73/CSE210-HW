using System.Net;

public class Jobs
{
    public string _jobTitle = "";
    public string _company = "";
    public double _startYear = 0;
    public List<Jobs> _job = new List<Jobs>();
    public double _endYear = 0;
    public static List<Jobs> GetInfo()
    {
        string more = "yes";
        List<Jobs> x = new List<Jobs>();
        do
        { 
        Jobs job = new Jobs();
        Console.WriteLine("What is your Job title?");
        job._jobTitle = Console.ReadLine();
        Console.WriteLine("What is the company?");
        job._company = Console.ReadLine();
        Console.WriteLine("When did you start?");
        job._startYear = int.Parse(Console.ReadLine());
        Console.WriteLine("When did you quit?");
        job._endYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Do you have another job to eneter?");
        more = Console.ReadLine();
        x.Add(job);
        }while(more == "yes");
        return x;

    }
    public static void GiveInfo(Jobs n1)
    {
    
        Console.WriteLine($"{n1._jobTitle} ({n1._company}) {n1._startYear}-{n1._endYear}");

    }
}