using System.ComponentModel;

class Exercise
{
    private DateTime _amountofTime;

    private string _type;

    private bool _complete;


    public Exercise(string type, bool complete)
    {
        _type = type;

        _complete = complete;

    }
    public DateTime CreateExercise()
    {
        int seconds;

        do
        {
            Console.WriteLine($"{_type} Exercise: ");
            Console.Write("How long do you want to do this exercise for?\n> ");
            seconds = int.Parse(Console.ReadLine());
        
            if(seconds > 0 | seconds < 99)
            {
                DateTime now = DateTime.Now;
    
                DateTime endTime = now.AddSeconds(seconds + 1);

                _amountofTime = endTime;
            }
            else
            {
                Console.WriteLine("Incorrect values, please try again. \n> ");
                
            }
        }while(seconds < 0 | seconds > 99);
        return _amountofTime;
    }
}