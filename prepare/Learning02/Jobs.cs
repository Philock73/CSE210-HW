public class Jobs
{
    public string _jobTitle = "";
    public string _company = "";
    public double _startYear = 0;
    public double _endYear = 0;
    public static void GetInfo(Jobs n1)
    {
        Console.WriteLine("What is your Job title?");
        n1._jobTitle = Console.ReadLine();
        Console.WriteLine("What is the company?");
        n1._company = Console.ReadLine();
        Console.WriteLine("When did you start?");
        n1._startYear = int.Parse(Console.ReadLine());
        Console.WriteLine("When did you quit?");
        n1._endYear = int.Parse(Console.ReadLine());
    }
    public static void GiveInfo(Jobs n1)
    {
        Console.WriteLine($"{n1._jobTitle} ({n1._company}) {n1._startYear}-{n1._endYear}");

    }
}