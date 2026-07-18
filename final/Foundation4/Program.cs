using System;

class Program
{
    static void Main(string[] args)
    {
        string _date = DateTime.Now.ToShortDateString();
        Running myRunning = new Running(10, _date, 60, 15, 3 , 6);
        Cycling myCycling = new Cycling(8, _date, 35, 56, 8, 6);
        Swimming mySwimming = new Swimming(15, _date, 55, 750, 4, 1);

        mySwimming.GetSummarry();

        myCycling.GetSummarry();

        myRunning.GetSummarry();
    }
}